// https://developer.valvesoftware.com/wiki/Smartprop_Operations

using KeyValue3;

namespace CS2SmartPropEditor.VSmart;

public abstract class VSmartOperation : VSmartNode
{
}

public sealed class TraceToPointOperation : VSmartOperation
{
	public override required string Class {get; init;} = "CSmartPropOperation_TraceToPoint";
}
public sealed class TraceToLineOperation : VSmartOperation
{
	public override required string Class {get; init;} = "CSmartPropOperation_TraceToLine";
}
public sealed class SetTintColorOperation : VSmartOperation
{
	public override required string Class {get; init;} = "CSmartPropOperation_SetTintColor";
}
public sealed class SetVariableOperation : VSmartOperation
{
	public override required string Class {get; init;} = "CSmartPropOperation_SetVariable";
}
public sealed class SaveStateOperation : VSmartOperation
{
	public override required string Class {get; init;} = "CSmartPropOperation_SaveState";
}
public sealed class RestoreStateOperation : VSmartOperation
{
	public override required string Class {get; init;} = "CSmartPropOperation_RestoreState";
}
public sealed class SavePositionOperation : VSmartOperation
{
	public override required string Class {get; init;} = "CSmartPropOperation_SavePosition";
}
public sealed class SaveDirectionOperation : VSmartOperation
{
	public override required string Class {get; init;} = "CSmartPropOperation_SaveDirection";
}
public sealed class SaveScaleOperation : VSmartOperation
{
	public override required string Class {get; init;} = "CSmartPropOperation_SaveScale";
}
public sealed class SaveSurfaceNormalOperation : VSmartOperation
{
	public override required string Class {get; init;} = "CSmartPropOperation_SaveSurfaceNormal";
}
public sealed class ComputeDotProduct3DOperation : VSmartOperation
{
	public override required string Class {get; init;} = "CSmartPropOperation_ComputeDotProduct3D";
}
public sealed class ComputeCrossProduct3DOperation : VSmartOperation
{
	public override required string Class {get; init;} = "CSmartPropOperation_ComputeCrossProduct3D";
}
public sealed class ComputeDistance3DOperation : VSmartOperation
{
	public override required string Class {get; init;} = "CSmartPropOperation_ComputeDistance3D";
}
public sealed class ComputeVectorBetweenPoints3DOperation : VSmartOperation
{
	public override required string Class {get; init;} = "CSmartPropOperation_ComputeVectorBetweenPoints3D";
}
public sealed class ComputeNormalizedVector3DOperation : VSmartOperation
{
	public override required string Class {get; init;} = "CSmartPropOperation_ComputeNormalizedVector3D";
}
public sealed class ComputeProjectVector3DOperation : VSmartOperation
{
	public override required string Class {get; init;} = "CSmartPropOperation_ComputeProjectVector3D";
}
public sealed class CreateLocatorOperation : VSmartOperation
{
	public override required string Class {get; init;} = "CSmartPropOperation_CreateLocator";
}

public sealed class CreateSizerOperation : VSmartOperation
{
	public override required string Class {get; init;} = "CSmartPropOperation_CreateSizer";

	[KV3Property("m_flInitialMinX")]
	public float? InitialMinX;

	[KV3Property("m_flInitialMaxX")]
	public float? InitialMaxX;

	[KV3Property("m_flConstraintMinX")]
	public float? ConstraintMinX;

	[KV3Property("m_flConstraintMaxX")]
	public float? ConstraintMaxX;

	[KV3Property("m_OutputVariableMinX")]
	public string? OutputVariableMinX;

	[KV3Property("m_OutputVariableMaxX")]
	public string? OutputVariableMaxX;

	[KV3Property("m_flInitialMinY")]
	public float? InitialMinY;

	[KV3Property("m_flInitialMaxY")]
	public float? InitialMaxY;

	[KV3Property("m_flConstraintMinY")]
	public float? ConstraintMinY;

	[KV3Property("m_flConstraintMaxY")]
	public float? ConstraintMaxY;

	[KV3Property("m_OutputVariableMinY")]
	public string? OutputVariableMinY;

	[KV3Property("m_OutputVariableMaxY")]
	public string? OutputVariableMaxY;

	[KV3Property("m_flInitialMinZ")]
	public float? InitialMinZ;

	[KV3Property("m_flInitialMaxZ")]
	public float? InitialMaxZ;

	[KV3Property("m_flConstraintMinZ")]
	public float? ConstraintMinZ;

	[KV3Property("m_flConstraintMaxZ")]
	public float? ConstraintMaxZ;

	[KV3Property("m_OutputVariableMinZ")]
	public string? OutputVariableMinZ;

	[KV3Property("m_OutputVariableMaxZ")]
	public string? OutputVariableMaxZ;
}

public sealed class CreateRotatorOperation : VSmartOperation
{
	public override required string Class {get; init;} = "CSmartPropOperation_CreateRotator";

	/// <summary>
	/// Axis around which the rotation will occur
	/// </summary>
	[KV3Property("m_vRotationAxis")]
	public Vector3? RotationAxis;

	/// <summary>
	/// Coordinate space the axis of rotation is specified in.
	/// </summary>
	//[KV3Property("m_CoordinateSpace")]
	//public string? CoordinateSpace;

	/// <summary>
	/// Radius at which the rotator handle should be displayed.
	/// </summary>
	[KV3Property("m_flDisplayRadius")]
	public float? DisplayRadius;

	/// <summary>
	/// Should the rotation be applied to the current transform.
	/// </summary>
	[KV3Property("m_bApplyToCurrentTrasnform")]
	public bool? ApplyToCurrentTransform;

	// TODO: Find corresponding class members to set the limits
	/// <summary>
	/// If enabled, the minimum and maximum rotation angles will be used to limit the range of the rotation.
	/// </summary>
	[KV3Property("m_bEnforceLimits")]
	public bool? EnforceLimits;

	/// <summary>
	/// Specifies a float variable to which the rotation value should be output.
	/// The variable only receives the rotation around the axis, the axis of rotation does not affect this output.
	/// </summary>
	[KV3Property("m_OutputVariable")]
	public string? OutputVariable;
}

public sealed class ResetRotationOperation : VSmartOperation
{
	public override required string Class {get; init;} = "CSmartPropOperation_ResetRotation";
}

public sealed class SetOrientationOperation : VSmartOperation
{
	public override required string Class {get; init;} = "CSmartPropOperation_SetOrientation";
}

public sealed class SetPositionOperation : VSmartOperation
{
	public override required string Class {get; init;} = "CSmartPropOperation_SetPosition";
}

public sealed class ResetScaleOperation : VSmartOperation
{
	public override required string Class {get; init;} = "CSmartPropOperation_ResetScale";
}

public sealed class RotateOperation : VSmartOperation
{
	public override required string Class {get; init;} = "CSmartPropOperation_Rotate";

	[KV3Property("m_vRotation")]
	public Vector3? Rotation;
}

public sealed class TranslateOperation : VSmartOperation
{
	public override required string Class {get; init;} = "CSmartPropOperation_Translate";

	[KV3Property("m_vPosition")]
	public string? Position;
}

public sealed class RotateTowardsOperation : VSmartOperation
{
	public override required string Class {get; init;} = "CSmartPropOperation_RotateTowards";
}

/// <summary>
/// Apply a scale to the current transform.
/// </summary>
public sealed class ScaleOperation : VSmartOperation
{
	public override required string Class {get; init;} = "CSmartPropOperation_Scale";

	[KV3Property("m_flScale")]
	public float? Scale;
}

/// <summary>
/// Apply a random position offset to the current transform.
/// </summary>
public sealed class RandomOffsetOperation : VSmartOperation
{
	public override required string Class {get; init;} = "CSmartPropOperation_RandomOffset";

	[KV3Property("m_vRandomPositionMin")]
	public Vector3? RandomPositionMin;

	[KV3Property("m_vRandomPositionMax")]
	public Vector3? RandomPositionMax;
}

/// <summary>
/// Apply a random rotation to the current transform.
/// </summary>
public sealed class RandomRotationOperation : VSmartOperation
{
	public override required string Class {get; init;} = "CSmartPropOperation_RandomRotation";

	[KV3Property("m_vRandomRotationMin")]
	public Vector3? RandomRotationMin;

	[KV3Property("m_vRandomRotationMax")]
	public Vector3? RandomRotationMax;
}

/// <summary>
/// Apply a random scale to the current transform.
/// </summary>
public sealed class RandomScaleOperation : VSmartOperation
{
	public override required string Class {get; init;} = "CSmartPropOperation_RandomScale";

	[KV3Property("m_flRandomScaleMin")]
	public float? RandomScaleMin;

	[KV3Property("m_flRandomScaleMax")]
	public float? RandomScaleMax;
}

public sealed class TraceOperation : VSmartOperation
{
	public override required string Class {get; init;} = "CSmartPropOperation_Trace";
}

public sealed class TraceInDirectionOperation : VSmartOperation
{
	public override required string Class {get; init;} = "CSmartPropOperation_TraceInDirection";
}
