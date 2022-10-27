// Copyright Epic Games, Inc. All Rights Reserved.

using System.IO;
using UnrealBuildTool;
using System;

public class mtlpp_bug : ModuleRules
{
	public mtlpp_bug(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
        
        string engineDirectory = Path.GetFullPath(Target.RelativeEnginePath);
        string metalRHIIncludePrivatePath = Path.Combine(engineDirectory, "Source/Runtime/Apple/MetalRHI/Private");
        string metalRHIIncludePublicPath = Path.Combine(engineDirectory, "Source/Runtime/Apple/MetalRHI/Public");
        PrivateIncludePaths.AddRange(new string[] { metalRHIIncludePrivatePath, metalRHIIncludePublicPath });

        PrivateDependencyModuleNames.AddRange(
            new string[] { "mtlpp_bug", "Core", "CoreUObject", "Engine", "MetalRHI", "RHI", "RenderCore", "MTLPP" });

        string pluginRootPath = Directory.GetParent(ModuleDirectory).FullName;
        string advertyRHIIncludePath = Path.Combine(pluginRootPath, "mtlpp_bug/Public");
        PublicIncludePaths.Add(advertyRHIIncludePath);
	}
}
