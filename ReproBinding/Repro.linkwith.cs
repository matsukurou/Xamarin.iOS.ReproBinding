using System;
using ObjCRuntime;

[assembly: LinkWith ("Repro.a", 
    LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator,
    ForceLoad = true,
    Frameworks = "AVFoundation CoreMedia SystemConfiguration", 
    LinkerFlags = "-lz",
    IsCxx = true)]