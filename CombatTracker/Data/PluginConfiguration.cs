using CombatTracker.Models;

using Dalamud.Configuration;

using System;
using System.Collections.Generic;

namespace CombatTracker.Data
{
    [Serializable]
    public class PluginConfiguration : IPluginConfiguration
    {
        public int Version { get; set; } = 2;

        public IList<Trigger> Triggers { get; set; }
    }
}
