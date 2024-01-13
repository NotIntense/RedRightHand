using Exiled.API.Features;
using Exiled.Events.EventArgs.Server;
using PlayerRoles;
using System;
using System.Collections.Generic;
using System.Linq;
using Random = UnityEngine.Random;

namespace TheRedRightHand.Handlers;

public static class ServerHandler
{
    public static Configuration Configuration => Main.Instance.Config;

    public static void OnSpawnWave(RespawningTeamEventArgs ev)
    {
        if (ev.NextKnownTeam == Respawning.SpawnableTeamType.ChaosInsurgency) 
            return;

        if (Main.SpawnWaves >= Configuration.SpawnWavesNeeded || ev.Players.Count < Configuration.MinWaveSize)
        {
            if (Main.SpawnWaves > Configuration.SpawnWavesNeeded && !Configuration.CanRespawnAgain)
                return;

            ev.IsAllowed = false;

            foreach(Player ply in CheckPlayerAmount(ev.Players))
            {
                ply.Role.Set(Configuration.Role, RoleSpawnFlags.UseSpawnpoint);
                ply.ClearInventory(); //just in case

                ply.AddItem(Configuration.Items);
                ply.AddItem(Configuration.Ammos);

                ply.Health = Configuration.Health;

                if (Configuration.ShowBroadcastToPlayer)
                    ply.Broadcast(5, Configuration.BroadcastToShow);

                ply.CustomInfo = ReplaceRandomNumber(Configuration.CustomInfo);

            }
            Cassie.MessageTranslated(Configuration.CassieAnnouncment, Configuration.CassieSubtitles);
        }
        else
        {
            Main.SpawnWaves++;
            return;
        }
    }

    private static List<Player> CheckPlayerAmount(List<Player> players)
    {
        List<Player> spawningPlayers = players;

        if (Configuration.MaxWaveSize != -1 && spawningPlayers.Count > Configuration.MaxWaveSize)
        {
            spawningPlayers = spawningPlayers.Take(Configuration.MaxWaveSize).ToList();
        }

        return spawningPlayers;
    }

    private static string ReplaceRandomNumber(string input)
    {
        if (input.Contains("{randNum}"))
        {
            int randomNumber = Random.Range(100, 1001);
            return input.Replace("{randNum}", randomNumber.ToString());
        }
        return input;
    }
}
