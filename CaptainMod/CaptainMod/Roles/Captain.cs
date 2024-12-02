using MiraAPI.Roles;
using MiraAPI.Utilities.Assets;
using CaptainMod.Patches.CustomGameOverReasons;
using UnityEngine;

namespace CaptainMod.Roles;

[RegisterCustomRole]
public class Captain : CrewmateRole, ICustomRole
{
    public string RoleName => "Captain";
    public string RoleLongDescription => "Control the ship!";
    public string RoleDescription => RoleLongDescription;
    public Color RoleColor => new Color32(150, 125, 125, 255);
    public ModdedRoleTeams Team => ModdedRoleTeams.Crewmate;

    public CustomRoleConfiguration Configuration => new CustomRoleConfiguration(this)
    {
        CanGetKilled = true,
        CanUseVent = false,
        UseVanillaKillButton = false,
    };

    public override bool DidWin(GameOverReason gameOverReason)
    {
        return gameOverReason == (GameOverReason)CustomGameOverReasonsEnum.KillEveryone;
    }
}
