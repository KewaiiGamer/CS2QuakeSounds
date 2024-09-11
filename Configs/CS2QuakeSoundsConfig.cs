using CounterStrikeSharp.API.Core;
using System;
using System.Text;
using System.Text.Json.Serialization;

namespace CS2QuakeSounds.Configs
{
    public class CS2QuakeSoundsConfig : BasePluginConfig
    {
        [JsonPropertyName("sounds")]
        public List<string> Sounds { get; set; } = ["sounds/quake/quepirocada.vsnd_c"];
        
        [JsonPropertyName("headshot_enable")]
        public bool HeadshotEnabled { get; set; } = [true];

        [JsonPropertyName("knife_enable")]        
        public bool KnifeEnabled { get; set; } = [true];
        
        [JsonPropertyName("hegrenade_enable")]
        public bool GrenadeEnabled { get; set; } = [true];

        [JsonPropertyName("inferno_enable")]
        public bool InfernoEnabled { get; set; } = [true];

        [JsonPropertyName("thrusmoke_enabled")]
        public bool ThrusmokeEnabled { get; set; } = [true];

        [JsonPropertyName("noscope_enabled")]
        public bool NoscopeEnabled { get; set; } = [true];
        
    }
}