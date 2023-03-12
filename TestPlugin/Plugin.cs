using PluginAPI.Core;
using PluginAPI.Core.Attributes;
using PluginAPI.Enums;
using PluginAPI.Events;

namespace TestPlugin.Plugin
{
    internal class Plugin
    {
        [PluginConfig]
        public Config Configuration;

        [PluginEntryPoint("Testing Plugin", "1.0.0", "testing testing", "davidsebesta")]
        void Enabled() => EventManager.RegisterEvents((object)this);

        [PluginEvent(ServerEventType.PlayerJoined)]
        void OnPlayerJoin(Player player)
        {
            Log.Info($"Player &6{player.UserId}&r joined this server, logged via plugin.");
        }
    }
}
