using System;
using PluginAPI;
using PluginAPI.Events.EventArgs;

namespace Server_Tools.Handlers
{
    public class Utils
    {
        Config Config = new Config();
        public void OnDeath(PlayerDeathEvent ev)
        {
            if (Config.RespawnReminder)
            {
                string message = Config.RespawnText;
                ev.Player.Broadcast(message, 25);
            }
        }

        public void Target(Scp049AddTargetEvent ev)
        {
            if (Config.AddTarget049Notification)
            {
                if (ev.Finalized)
                {
                    Player pl = Player.GetPlayer(ev.Target);
                    pl.Broadcast(Config.AddTarget049, 10);
                }
            }
        }
        
        public void Lockdown(LockdownToggleEvent ev)
        {
            if (Config.LockdownLeverLock)
            {
                if (ev.Finalized == false)
                {
                    if (ev.Locked == false) 
                    {
                        ev.Disallow();
                    }
                }
            }
        }
    }
}