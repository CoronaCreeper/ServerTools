using PluginAPI;
using PluginAPI.Events.EventArgs;

namespace Server_Tools.Handlers
{
    public class Logs
    {
        Config Config = new Config();
        public void Pickup(PlayerPickupItemEvent ev)
        {
            if(Config.EnableLogs) Log.Info(ev.Player.PlayerName +" podniosl "+ev.Item.GetItemName());
        }

        public void Death(PlayerDeathEvent ev)
        {
            if(Config.EnableLogs) Log.Info(ev.Player.PlayerName+" zginal. Powod: "+ev.Attacker.name);
        }

        public void Lockdown(LockdownToggleEvent ev)
        {
            if(Config.EnableLogs) Log.Info(ev.Player.PlayerName +" odblokowal HCZ");
        }

        public void Femur(ActivateFemurBreakerEvent ev)
        {
            if(Config.EnableLogs) Log.Info(ev.Player.PlayerName +" aktywowal femur braker (zabezpieczyl SCP-106)");
        }

        public void Drop(PlayerDropItemEvent ev)
        {
            if(Config.EnableLogs) Log.Info(ev.Player.PlayerName+" wyrzucil przedmiot "+ev.Item.GetItemName());
        }
    }
}