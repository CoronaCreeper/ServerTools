# ServerTools
An SCP-ET plugin that add more logs & utils for servers
## Features
- Player Join/Leave Announcments
- More Logs (Pickup Item, SCP106 Recontaint etc)
- LCZ Lockdown Lever Lock
- SCP-049 AddTarget notification
## Config
|Config Line|Type|Description|
|-----------|----|-----------|
|IsEnabled|bool|If True, plugin will load.|
|EnableLogs|bool|If True server will receive more logs.|
|AddTarget049Notification|bool|If True players will be notified of being 049 target.|
|RespawnReminder|bool|If True players will be notified about /respawn command after die.|
|LockdownLeverLock|bool|If True players will not be able to turn LCZ lockdown lever to "ON" again.|
|Join/LeaveAnnouncment|bool|If True, after player join/leave message will be sent.|
|RespawnText|string|A message that will remind players to respawn.|
|Join/LeaveText|string|A message that will show after player join/leave.|
|AddTarget049|string|A message that will show after SCP-049 targets player|
