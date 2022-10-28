// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class mtlpp_bugEditorTarget : TargetRules
{
	public mtlpp_bugEditorTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.AddRange( new string[] { "mtlpp_bug" } );
        if (Target.Platform == UnrealTargetPlatform.Mac)
        {
            bOverrideBuildEnvironment = true;
            AdditionalCompilerArguments = "-Wno-unused-but-set-variable";
        }
	}
}
