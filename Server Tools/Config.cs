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
        public string RespawnText { get; set; } = "<color=red>Remember to use</color> <color=lime>/respawn</color> <color=red>to respawn!</color>";
        public string JoinText { get; set; } = "<color=lime>{player}</color> Joined the server, server has <color=lime>{online}</color> players.";
        public string LeaveText { get; set; } = "<color=lime>{player}</color> left the server, server has <color=lime>{online}</color> players.";
        public string AddTarget049 { get; set; } = "<color=orange>SCP-049 has targeted you, </color><color=red>RUN!</color>";
    }
}