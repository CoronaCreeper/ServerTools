using System;
using PluginAPI;
using PluginAPI.Events.EventArgs;

namespace Server_Tools.Handlers
{
    public class JoinLeave
    {
        Config Config = new Config();
        
        public void OnJoin(PlayerJoinEvent ev)
        {
            if (ev.Finalized)
            {
                if (Config.JoinAnnouncment)
                {
                    String message = Config.JoinText.Replace("{player}", ev.Player.PlayerName)
                        .Replace("{online}", Server.PlayersOnline.ToString());
                    Server.SendChatMessage(message);
                }
            }
        }

        public void OnLeave(PlayerLeaveEvent ev)
        {
            if (ev.Finalized)
            {
                if (Config.LeaveAnnouncment)
                {
                    String message = Config.LeaveText.Replace("{player}", ev.Player.PlayerName)
                        .Replace("{online}", Server.PlayersOnline.ToString());
                    Server.SendChatMessage(message);
                }
            }
        }
    }
}