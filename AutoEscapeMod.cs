﻿using Assets.Scripts.Models.Bloons.Behaviors;
using Assets.Scripts.Simulation.Bloons;
using Assets.Scripts.Unity.UI_New.InGame;
using AutoEscape;
using BTD_Mod_Helper;
using BTD_Mod_Helper.Extensions;
using MelonLoader;

[assembly: MelonInfo(typeof(AutoEscapeMod), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
namespace AutoEscape;

public class AutoEscapeMod : BloonsTD6Mod
{
    public override bool PreBloonLeaked(Bloon bloon)
    {
        if (        if (bloon.GetModifiedTotalLeakDamage() < InGame.instance.bridge.GetHealth() + InGame.Bridge.simulation.Shield | bloon.GetModifiedTotalLeakDamage() > InGame.instance.bridge.GetHealth() + InGame.Bridge.simulation.Shield
            && !InGameData.CurrentGame.IsSandbox && !bloon.bloonModel.HasBehavior<GoldenBloonModel>())
        {
            if (!InGame.instance.quitting)
            {
                InGame.instance.Quit();
                
                ModHelper.Msg<AutoEscapeMod>("You're Welcome.");
            }
            return false;
        }
        return true;
    }
        
}
