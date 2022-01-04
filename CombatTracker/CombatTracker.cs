using CombatTracker.Data;

using Dalamud.IoC;
using Dalamud.Plugin;

using System;

namespace CombatTracker
{
    public unsafe partial class CombatTracker : IDalamudPlugin
    {
        private static DalamudPluginInterface _pluginInterface;


        private static PluginConfiguration _configuration;

        public CombatTracker(
            DalamudPluginInterface pluginInterface
            )
        {
            _pluginInterface = pluginInterface;

            _configuration = _pluginInterface.GetPluginConfig() as PluginConfiguration;
        }

        public string Name => nameof(CombatTracker);

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
