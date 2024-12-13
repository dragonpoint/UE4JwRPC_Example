// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class ExampleJwRPCEditorTarget : TargetRules
{
	public ExampleJwRPCEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
        DefaultBuildSettings = BuildSettingsVersion.V5;
        CppStandard = CppStandardVersion.Cpp20;
        bOverrideBuildEnvironment = true;
        IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_5;
        ExtraModuleNames.AddRange( new string[] { "ExampleJwRPC" } );
	}
}
