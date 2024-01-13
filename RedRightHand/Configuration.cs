using Exiled.API.Interfaces;
using PlayerRoles;
using System.Collections.Generic;
using System.ComponentModel;

namespace TheRedRightHand;

public class Configuration : IConfig
{
    [Description("Gets or sets if the plugin is enabled.")]
    public bool IsEnabled { get; set; } = true;

    [Description("Gets or sets if the plugin's debug logs are enabled.")]
    public bool Debug { get; set; } = false;

    [Description("Gets or sets the health of Alpha - 1 units.")]
    public int Health { get; set; } = 200;

    [Description("Gets or sets the  of Alpha - 1 units. Use {randNum} for a random number.")]
    public string CustomInfo { get; set; } = "Alpha - 1 | Unit {randNum}";

    [Description("Gets or sets if the amount of MTF spawnwaves needed for MTF Alpha - 1 (Red Right Hand) to spawn.")]
    public int SpawnWavesNeeded { get; set; } = 2;

    [Description("Gets or sets if the MTF unit Alpha - 1 can respawn every next MTF wave.")]
    public bool CanRespawnAgain { get; set; } = false;

    [Description("Gets or sets if C.A.S.S.I.E announces MTF unit Alpha - 1 arrival.")]
    public bool CanCassieAnnouncment { get; set; } = true;

    [Description("Gets or sets the contents of C.A.S.S.I.E's announcment.")]
    public string CassieAnnouncment { get; set; } = "MTFUNIT Alpha 1 hasentered allremaining";

    public string CassieSubtitles { get; set; } = "Mobile Task Force Unit ALPHA-1 has entered the facility. " +
        "All remaining personel are advised to proceed with standard evactuation protocols, until a MTF squad reaches your destination.";

    [Description("Gets or sets if the MTF unit Alpha - 1 members get a broadcast on spawn.")]
    public bool ShowBroadcastToPlayer { get; set; } = false;

    [Description("Gets or sets if the MTF unit Alpha - 1 broadcast, if 'ShowBroadcastToPlayer' is 'true'.")]
    public string BroadcastToShow { get; set; } = "You've spawned as a MTF Alpha - 1 Unit!";

    [Description("Gets or sets the minimum units requried to spawn of MTF Alpha - 1")]
    public int MinWaveSize { get; set; } = 3;

    [Description("Gets or sets the max wave sides of MTF Alpha - 1 units. Leave at -1 for unlimited.")]
    public int MaxWaveSize { get; set; } = -1;

    [Description("Gets or sets the role of MTF Alpha - 1 units.")]
    public RoleTypeId Role { get; set; } = RoleTypeId.NtfCaptain;

    [Description("Gets or sets the inventory items of the units of MTF Alpha - 1.")]
    public List<ItemType> Items = new()
    {
        ItemType.KeycardO5,
        ItemType.GunFRMG0,
        ItemType.GunCOM18,
        ItemType.Medkit,
        ItemType.SCP500,
        ItemType.GrenadeHE,
        ItemType.Radio,
        ItemType.ArmorHeavy,
    };

    [Description("Gets or sets the ammo of the units of MTF Alpha - 1.")]
    public List<ItemType> Ammos = new()
    {
        ItemType.Ammo556x45,
        ItemType.Ammo556x45,
        ItemType.Ammo556x45,
        ItemType.Ammo556x45,
        ItemType.Ammo556x45,
        ItemType.Ammo9x19,
        ItemType.Ammo9x19,
        ItemType.Ammo9x19,
    };
}
