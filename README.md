# Red Right Hand - Alpha-1 MTF Unit Plugin

Frustrated by persistent anomalies and containment breaches at Site-02, the O5 Council has reluctantly dispatched Alpha-1 "Red Right Hand" to tackle the challenges that no one else can handle. This plugin introduces a new Mobile Task Force (MTF) unit, Alpha-1, renowned as the "Red Right Hand." Operating at the highest level, they report directly to the O5 Council, equipped with cutting-edge weaponry, heavy armor, and exceptional resilience. Every aspect of this MTF unit is customizable through the configuration settings, providing flexibility for integration into various games.

Default Config:

``RRH:
# Gets or sets if the plugin is enabled.
  is_enabled: true
  # Gets or sets if the plugin's debug logs are enabled.
  debug: false
  # Gets or sets the health of Alpha - 1 units.
  health: 200
  # Gets or sets the CustomInfo of Alpha - 1 units. Use {randNum} for a random number
  custom_info: 'Alpha - 1 | Unit {randNum}'
  # Gets or sets if the amount of MTF spawnwaves needed for MTF Alpha - 1 (Red Right Hand) to spawn.
  spawn_waves_needed: 2
  # Gets or sets if the MTF unit Alpha - 1 can respawn every next MTF wave.
  can_respawn_again: false
  # Gets or sets if C.A.S.S.I.E announces MTF unit Alpha - 1 arrival.
  can_cassie_announcment: true
  # Gets or sets the contents of C.A.S.S.I.E's announcment.
  cassie_announcment: 'MTFUNIT Alpha 1 hasentered allremaining'
  cassie_subtitles: 'Mobile Task Force Unit ALPHA-1 has entered the facility. All remaining personel are advised to proceed with standard evactuation protocols, until a MTF squad reaches your destination.'
  # Gets or sets if the MTF unit Alpha - 1 members get a broadcast on spawn.
  show_broadcast_to_player: false
  # Gets or sets if the MTF unit Alpha - 1 broadcast, if 'ShowBroadcastToPlayer' is 'true'.
  broadcast_to_show: 'You''ve spawned as a MTF Alpha - 1 Unit!'
  # Gets or sets the minimum units requried to spawn of MTF Alpha - 1
  min_wave_size: 3
  # Gets or sets the max wave sides of MTF Alpha - 1 units. Leave at -1 for unlimited.
  max_wave_size: -1
  # Gets or sets the role of MTF Alpha - 1 units.
  role: NtfCaptain
exiled_credits:
  is_enabled: true
  debug: false
  # Info side - Badge, CustomPlayerInfo, FirstAvailable
  mode: FirstAvailable
  # Overrides badge if exists
  badge_override: false
  # Overrides Custom Player Info if exists
  custom_player_info_override: false
  # Whether or not the plugin should ignore a player's DNT flag. By default (false), players with DNT flag will not be checked for credit tags.
  ignore_dnt_flag: false``
