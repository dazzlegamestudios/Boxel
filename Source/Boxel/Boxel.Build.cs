// Copyright 1998-2015 Epic Games, Inc. All Rights Reserved.

namespace UnrealBuildTool.Rules
{
	public class Boxel : ModuleRules
	{
		public Boxel(TargetInfo Target)
		{
			PublicIncludePaths.AddRange(
				new string[] {
					// ... add public include paths required here ...
				}
			);

			PrivateIncludePaths.AddRange(
				new string[] {
					"../Draco",
					// ... add other private include paths required here ...
				}
			);

			PublicDependencyModuleNames.AddRange(
				new string[] {
					"Core",
					"CoreUObject",
					"InputCore",
					"Engine",
					"Slate",
					"SlateCore",
					"RHI",
					"RenderCore",
					"ShaderCore"
					//"Landscape",
					//"RenderCore",
					//"PropertyEditor",
					//"ImageWrapper",
					//"EditorWidgets",
					// ... add other public dependencies that you statically link with here ...
				}
			);
			
			PrivateDependencyModuleNames.AddRange(
				new string[] {
					"EditorStyle",
					"Projects",
					"UnrealEd",
					"GameProjectGeneration"
				}
			);

			PrivateIncludePathModuleNames.AddRange(
				new string[] {
					//"MainFrame",
					//"DesktopPlatform",
					//"ContentBrowser",
					//"AssetTools",
				}
			);

			DynamicallyLoadedModuleNames.AddRange(
				new string[] {
					//"MainFrame",
					//"DesktopPlatform",
					//"ImageWrapper",
				}
			);
		}
	}
}