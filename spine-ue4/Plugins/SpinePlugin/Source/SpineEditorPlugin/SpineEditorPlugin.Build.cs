// Copyright 1998-2016 Epic Games, Inc. All Rights Reserved.

namespace UnrealBuildTool.Rules
{
	public class SpineEditorPlugin : ModuleRules
	{
		public SpineEditorPlugin(TargetInfo Target)
		{
			PublicIncludePaths.AddRange(new string[] { "SpineEditorPlugin/Public" });
            PrivateIncludePaths.AddRange(new string[] { "SpineEditorPlugin/Private" });
            PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine" });
			PrivateDependencyModuleNames.AddRange(new string[] { "RHI", "RenderCore", "ShaderCore" });
		}
	}
}