using PluginAPI;
using PluginAPI.Events.EventArgs;

namespace Server_Tools.Handlers
{
    public class Logs
    {
        Config Config = new Config();
        public void Pickup(PlayerPickupItemEvent ev)
        {
            if(Config.EnableLogs) if(ev.Finalized) Log.Info(ev.Player.PlayerName +" picked up "+ev.Item.GetItemName());
        }
        
        public void Drop(PlayerDropItemEvent ev)
        {
            if(Config.EnableLogs) if(ev.Finalized) Log.Info(ev.Player.PlayerName+" throw "+ev.Item.GetItemName());
        }

        public void Death(PlayerDeathEvent ev)
        {
            if(Config.EnableLogs) if(ev.Finalized) Log.Info(ev.Player.PlayerName+" died. Reason: "+ev.Attacker.name);
        }

        public void Lockdown(LockdownToggleEvent ev)
        {
            if(Config.EnableLogs) if(ev.Finalized) Log.Info(ev.Player.PlayerName + " unlocked HCZ");
        }

        public void Femur(ActivateFemurBreakerEvent ev)
        {
            if(Config.EnableLogs) if(ev.Finalized) Log.Info(ev.Player.PlayerName +" activated femur breaker (recontained scp-106)");
        }
    }
}