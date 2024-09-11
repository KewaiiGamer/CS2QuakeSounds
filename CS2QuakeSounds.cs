﻿using CounterStrikeSharp.API;
using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Core.Attributes;
using CounterStrikeSharp.API.Core.Translations;
using CS2QuakeSounds.Configs;
using System.Collections.Generic;
using CounterStrikeSharp.API.Modules.Events;
using CounterStrikeSharp.API.Core.Attributes.Registration;


namespace CommandVote
{
    public class CS2QuakeSounds : BasePlugin, IPluginConfig<CS2QuakeSoundsConfig>
    {
        public override string ModuleName => "CS2QuakeSounds";
        public override string ModuleVersion => "1.0.0";
        public override string ModuleAuthor => "Kewaii";
        public override string ModuleDescription => "Quake sounds on death";
        Random random = new Random();
        Dictionary<string, int> Votes = new();
        public CS2QuakeSoundsConfig Config { get; set; } = new CS2QuakeSoundsConfig();
        public void OnConfigParsed(CS2QuakeSoundsConfig config)
        {
            this.Config = config;
        }
        
        [GameEventHandler]
        public HookResult OnPlayerDeath(EventPlayerDeath @event, GameEventInfo info)
        {
            int index = random.Next(Config.Sounds.Count);
            string song = Config.Sounds[index];
            var players = Utilities.GetPlayers();
            foreach (var player in players)
            {
                if (player != null && player.IsValid)
                {
                    playSound = false
                    if (@event.Weapon == "hegrenade" && this.Config.GrenadeEnabled)
                    {
                        playSound = true
                    } 
                    if (@event.Weapon == "knife" && this.Config.KnifeEnabled)                    
                    {
                        playSound = true
                    }
                    if (@event.Weapon == "inferno" && this.Config.InfernoEnabled)
                    {
                        playSound = true
                    }
                    if (@event.Noscope && this.Config.NoscopeEnabled)
                    {
                        playSound = true
                    }
                    if (@event.Thrusmoke && this.Config.ThrusmokeEnabled)
                    {  
                        playSound = true
                    }
                    if (playSound)
                    {
                        player.ExecuteClientCommand($"play \"{song}\"");
                    }
                }
            }

            return HookResult.Continue;
        }
    }
}
