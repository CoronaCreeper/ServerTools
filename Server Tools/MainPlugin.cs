using System;
using PluginAPI;
using PluginAPI.Enums;
using PluginAPI.Events;
using PluginAPI.Events.EventArgs;
using Server_Tools.Handlers;

namespace Server_Tools
{
    public class MainPlugin : Plugin<Config>
    {
        public override string Name => "Server Tools";
        public override string Author => "CoronaCreeper#4884";
        public override Version Version => new Version(0, 1, 1);
        public override Version RequiredVersion => new Version(0, 2, 0);

        JoinLeave JL = new JoinLeave();
        Utils Util = new Utils();
        Logs Logs = new Logs();

        public override void OnEnabled()
        {
            PlayerEvents.PlayerJoin += JL.OnJoin;
            PlayerEvents.PlayerLeave += JL.OnLeave;
            
            PlayerEvents.PlayerDeath += Util.OnDeath;
            ScpEvents.Scp049AddTarget += Util.Target;
            ServerEvents.LockdownToggle += Util.Lockdown;
            
            PlayerEvents.PlayerPickupItem += Logs.Pickup;
            PlayerEvents.PlayerDeath += Logs.Death;
            ServerEvents.LockdownToggle += Logs.Lockdown;
            ServerEvents.ActivateFemurBreaker += Logs.Femur;
            PlayerEvents.PlayerDropItem += Logs.Drop;
        }

        public override void OnDisabled()
        {
            PlayerEvents.PlayerJoin -= JL.OnJoin;
            PlayerEvents.PlayerLeave -= JL.OnLeave;
            
            PlayerEvents.PlayerDeath -= Util.OnDeath;
            ScpEvents.Scp049AddTarget -= Util.Target;
            ServerEvents.LockdownToggle -= Util.Lockdown;
            
            PlayerEvents.PlayerPickupItem -= Logs.Pickup;
            PlayerEvents.PlayerDeath -= Logs.Death;
            ServerEvents.LockdownToggle -= Logs.Lockdown;
            ServerEvents.ActivateFemurBreaker -= Logs.Femur;
            PlayerEvents.PlayerDropItem -= Logs.Drop;
        }
    }
}