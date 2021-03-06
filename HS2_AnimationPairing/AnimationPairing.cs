﻿using BepInEx;
using IL_AnimationPair;
using KKAPI;
using KKAPI.Studio;
using static BepInEx.Harmony.HarmonyWrapper;

[BepInDependency(KoikatuAPI.GUID)]
[BepInPlugin(GUID, "HS2_AnimationPairing", VERSION)]
public class AnimationPairing : BaseUnityPlugin
{
    public const string GUID = "com.hooh.hs2.animpari";
    public const string VERSION = "1.0.0";

    public AnimationPairing Instance { get; set; }

    private void Awake()
    {
        Instance = this;
        if (!StudioAPI.InsideStudio) return;
        PatchAll(typeof(GameHooks));
    }
}