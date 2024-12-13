// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

[SupportedPlatforms(UnrealPlatformClass.Server)]
public class ExampleJwRPCServerTarget : TargetRules
{
	public ExampleJwRPCServerTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Server;
        DefaultBuildSettings = BuildSettingsVersion.V5;
        ExtraModuleNames.AddRange( new string[] { "ExampleJwRPC", } );
	}
}
