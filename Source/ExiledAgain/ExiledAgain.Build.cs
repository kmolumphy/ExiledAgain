// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class ExiledAgain : ModuleRules
{
	public ExiledAgain(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"ExiledAgain",
			"ExiledAgain/Variant_Platforming",
			"ExiledAgain/Variant_Platforming/Animation",
			"ExiledAgain/Variant_Combat",
			"ExiledAgain/Variant_Combat/AI",
			"ExiledAgain/Variant_Combat/Animation",
			"ExiledAgain/Variant_Combat/Gameplay",
			"ExiledAgain/Variant_Combat/Interfaces",
			"ExiledAgain/Variant_Combat/UI",
			"ExiledAgain/Variant_SideScrolling",
			"ExiledAgain/Variant_SideScrolling/AI",
			"ExiledAgain/Variant_SideScrolling/Gameplay",
			"ExiledAgain/Variant_SideScrolling/Interfaces",
			"ExiledAgain/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
