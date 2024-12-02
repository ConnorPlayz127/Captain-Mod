Welcome to the Among Us Captain Mod!

To play this mod, You need to use MiraAPI, You aslo need to use the custom reigon to play in public lobbies.

Click Windows + R and run the following line: %APPDATA%\..\LocalLow\Innersloth\Among Us

Then open "regionInfo.json" then paste this code:

```cs
{
  "CurrentRegionIdx": 0,
  "Regions": [
    {
      "$type": "StaticHttpRegionInfo, Assembly-CSharp",
      "Name": "North America",
      "PingServer": "matchmaker.among.us",
      "Servers": [
        {
          "Name": "Http-1",
          "Ip": "https://matchmaker.among.us",
          "Port": 443,
          "UseDtls": false,
          "Players": 0,
          "ConnectionFailures": 0
        }
      ],
      "TargetServer": null,
      "TranslateName": 289
    },
    {
      "$type": "StaticHttpRegionInfo, Assembly-CSharp",
      "Name": "Europe",
      "PingServer": "matchmaker-eu.among.us",
      "Servers": [
        {
          "Name": "Http-1",
          "Ip": "https://matchmaker-eu.among.us",
          "Port": 443,
          "UseDtls": false,
          "Players": 0,
          "ConnectionFailures": 0
        }
      ],
      "TargetServer": null,
      "TranslateName": 290
    },
    {
      "$type": "StaticHttpRegionInfo, Assembly-CSharp",
      "Name": "Asia",
      "PingServer": "matchmaker-as.among.us",
      "Servers": [
        {
          "Name": "Http-1",
          "Ip": "https://matchmaker-as.among.us",
          "Port": 443,
          "UseDtls": false,
          "Players": 0,
          "ConnectionFailures": 0
        }
      ],
      "TargetServer": null,
      "TranslateName": 291
    },
    {
      "$type": "StaticHttpRegionInfo, Assembly-CSharp",
      "Name": "Captain Mod",
      "PingServer": "play.simpfun.cn",
      "Servers": [
        {
          "Name": "http-1",
          "Ip": "https://au-cn.niko233.me",
          "Port": 443,
          "UseDtls": false,
          "Players": 0,
          "ConnectionFailures": 0
        }
      ],
      "TargetServer": null,
      "TranslateName": 1003
    }
  ]
}
```
