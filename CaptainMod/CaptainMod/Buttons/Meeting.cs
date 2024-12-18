using MiraAPI.Hud;
using MiraAPI.Utilities;
using MiraAPI.Utilities.Assets;
using CaptainMod.Resources;
using UnityEngine;
using CaptainMod.Roles;

namespace CaptainMod.Buttons;

[RegisterButton]
public class MeetingButton : CustomActionButton
{
    public override string Name => "Call Meeting";

    public override float Cooldown => 15;

    public override float EffectDuration => 0;

    public override int MaxUses => 1;

    public override LoadableAsset<Sprite> Sprite => CaptainModButtons.MeetingButton;

    public override bool Enabled(RoleBehaviour role)
    {
        return role is Captain;
    }

    protected override void OnClick()
    {
        var bt = ShipStatus.Instance.EmergencyButton;

        PlayerControl.LocalPlayer.NetTransform.Halt();
        var minigame = Object.Instantiate(bt.MinigamePrefab, Camera.main!.transform, false);

        var taskAdderGame = minigame as TaskAdderGame;
        if (taskAdderGame != null)
        {
            taskAdderGame.SafePositionWorld = bt.SafePositionLocal + (Vector2)bt.transform.position;
        }

        minigame.transform.localPosition = new Vector3(0f, 0f, -50f);
        minigame.Begin(null);
    }
}