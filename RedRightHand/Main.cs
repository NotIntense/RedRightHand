using Exiled.API.Features;
using System;
using TheRedRightHand.Handlers;

namespace TheRedRightHand;

public class Main : Plugin<Configuration>
{
    internal static int SpawnWaves = 0;

    public static Main Instance { get; private set; }

    public override string Name { get; } = "Red Right Hand";
    public override string Author { get; } = "NotIntense";
    public override string Prefix { get; } = "RRH";
    public override Version Version { get; } = new(1, 0, 0);
    public override Version RequiredExiledVersion { get; } = new(8, 0, 0);

    public override void OnEnabled()
    {
        base.OnEnabled();
        Instance = this;
        Exiled.Events.Handlers.Server.RespawningTeam += ServerHandler.OnSpawnWave;
    }

    public override void OnDisabled()
    {
        base.OnDisabled();
        Exiled.Events.Handlers.Server.RespawningTeam -= ServerHandler.OnSpawnWave;
        SpawnWaves = 0;
        Instance = null;
    }
}
