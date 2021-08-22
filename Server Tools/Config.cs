using PluginAPI.Interfaces;

namespace Server_Tools
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool EnableLogs { get; set; } = true;
        public bool AddTarget049Notification { get; set; } = true;
        public bool RespawnReminder { get; set; } = true;
        public bool LockdownLeverLock { get; set; } = true;
        public bool JoinAnnouncment { get; set; } = true;
        public bool LeaveAnnouncment { get; set; } = true;
        public static string RespawnText { get; set; } = "<color=red>Pamiętaj o możliwości odrodzenia się komendą</color> <color=lime>/respawn</color>";
        public static string JoinText { get; set; } = "<color=lime>{player}</color> dołączył na serwer. Na serwerze jest <color=lime>{online}</color> graczy.";
        public static string LeaveText { get; set; } = "<color=lime>{player}</color> opuścił na serwer. Na serwerze jest <color=lime>{online}</color> graczy.";
        public static string AddTarget049 { get; set; } = "<color=orange>SCP 049 obrał cię za cel. </color><color=red>UCIEKAJ!</color>";
    }
}