using UnrealBuildTool;

public class SPPGameTarget : TargetRules
{
	public SPPGameTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("SPPGame");
	}
}
