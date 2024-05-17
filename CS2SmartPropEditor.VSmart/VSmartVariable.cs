//https://developer.valvesoftware.com/wiki/Smartprop_Variables

namespace CS2SmartPropEditor.VSmart;

internal abstract class VSmartVariable : VSmartNode
{
	public required string VariableName;
	public string? DisplayName;
	public bool? ExposeAsParameter;
}

internal sealed class VSmartCoordinateSpaceVariable : VSmartVariable
{
	public override required string Class {get; init;} = "CSmartPropVariable_CoordinateSpace";
}

internal sealed class VSmartDirectionVariable : VSmartVariable
{
	public override required string Class {get; init;} = "CSmartPropVariable_Direction";
}

internal sealed class VSmartDistributionModeVariable : VSmartVariable
{
	public override required string Class {get; init;} = "CSmartPropVariable_DistributionMode";
}

internal sealed class VSmartRadiusPlacementModeVariable : VSmartVariable
{
	public override required string Class {get; init;} = "CSmartPropVariable_RadiusPlacementMode";
}

internal sealed class VSmartChoiceSelectionModeVariable : VSmartVariable
{
	public override required string Class {get; init;} = "CSmartPropVariable_ChoiceSelectionMode";
}

internal sealed class VSmartStringVariable : VSmartVariable
{
	public override required string Class {get; init;} = "CSmartPropVariable_String";

	public string? DefaultValue;
}

internal sealed class VSmartBoolVariable : VSmartVariable
{
	public override required string Class {get; init;} = "CSmartPropVariable_Bool";

	public bool? DefaultValue;
}

internal sealed class VSmartIntVariable : VSmartVariable
{
	public override required string Class {get; init;} = "CSmartPropVariable_Int";

	public int? DefaultValue;
	public int? ParamaterMinValue;
	public int? ParamaterMaxValue;
}

internal sealed class VSmartFloatVariable : VSmartVariable
{
	public override required string Class {get; init;} = "CSmartPropVariable_Float";

	public float? DefaultValue;
	public float? ParamaterMinValue;
	public float? ParamaterMaxValue;
}

internal sealed class VSmartVector2DVariable : VSmartVariable
{
	public override required string Class {get; init;} = "CSmartPropVariable_Vector2D";

	public Vector2? DefaultValue;
}

internal sealed class VSmartVector3DVariable : VSmartVariable
{
	public override required string Class {get; init;} = "CSmartPropVariable_Vector3D";

	public Vector3? DefaultValue;
}

internal sealed class VSmartVector4DVariable : VSmartVariable
{
	public override required string Class {get; init;} = "CSmartPropVariable_Vector4D";

	public Vector4? DefaultValue;
}

internal sealed class VSmartColorVariable : VSmartVariable
{
	public override required string Class {get; init;} = "CSmartPropVariable_Color";
}

internal sealed class VSmartAnglesVariable : VSmartVariable
{
	public override required string Class {get; init;} = "CSmartPropVariable_Angles";
}

internal sealed class VSmartMaterialGroupVariable : VSmartVariable
{
	public override required string Class {get; init;} = "CSmartPropVariable_MaterialGroup";
}

internal sealed class VSmartModelVariable : VSmartVariable
{
	public override required string Class {get; init;} = "CSmartPropVariable_Model";
}

internal sealed class VSmartApplyColorModeVariable : VSmartVariable
{
	public override required string Class {get; init;} = "CSmartPropVariable_ApplyColorMode";
}

internal sealed class VSmartTraceNoHitVariable : VSmartVariable
{
	public override required string Class {get; init;} = "CSmartPropVariable_TraceNoHit";
}


internal sealed class VSmartScaleModeVariable : VSmartVariable
{
	public override required string Class {get; init;} = "CSmartPropVariable_ScaleMode";
}

internal sealed class VSmartPickModeVariable : VSmartVariable
{
	public override required string Class {get; init;} = "CSmartPropVariable_PickMode";
}

internal sealed class VSmartGridPlacementModeVariable : VSmartVariable
{
	public override required string Class {get; init;} = "CSmartPropVariable_GridPlacementMode";
}

internal sealed class VSmartGridOriginModeVariable : VSmartVariable
{
	public override required string Class {get; init;} = "CSmartPropVariable_GridOriginMode";
}

internal sealed class VSmartPathPositionsVariable : VSmartVariable
{
	public override required string Class {get; init;} = "CSmartPropVariable_PathPositions";
}
