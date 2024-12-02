using MiraAPI.Utilities.Assets;

namespace CaptainMod.Resources;

public static class CaptainModButtons
{
    public static LoadableResourceAsset ExampleButton { get; } = new("CaptainMod.Resources.Button.png");
    public static LoadableResourceAsset InvisButton { get; } = new("CaptainMod.Resources.Invis.png");
    public static LoadableResourceAsset MeetingButton { get; } = new("CaptainMod.Resources.MeetingButton.png");
    public static LoadableResourceAsset ZoomButton { get; } = new("CaptainMod.Resources.ZoomButton.png");
    public static LoadableResourceAsset TeleportButton { get; } = new("CaptainMod.Resources.TeleportButton.png");
    public static LoadableResourceAsset CreditsButton { get; } = new("CaptainMod.Resources.ModStamp.png");
}