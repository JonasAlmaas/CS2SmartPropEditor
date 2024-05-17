// https://developer.valvesoftware.com/wiki/Smartprop_Elements

using KeyValue3;

namespace VSmart;

public abstract class Element : VSmartNode
{
}

public sealed class ModifyStateElement : Element
{
	public override required string Class {get; init;} = "CSmartPropElement_ModifyState";
}

public sealed class GroupElement : Element
{
	public override required string Class {get; init;} = "CSmartPropElement_Group";
}

public sealed class ModelElement : Element
{
	public override required string Class {get; init;} = "CSmartPropElement_Model";

	/// <summary>
	/// Asset path of the model to display.
	/// </summary>
	[KV3Property("m_sModelName")]
	public string? ModelName;

	/// <summary>
	/// Scale of the model, defaults to [1.0, 1.0, 1.0]
	/// </summary>
	[KV3Property("m_vModelScale")]
	public Vector3? ModelScale;

	/// <summary>
	/// The material group to use for this model
	/// </summary>
	[KV3Property("m_MaterialGroupName")]
	public string? MaterialGroupName;
}

public sealed class SmartPropElement : Element
{
	public override required string Class {get; init;} = "CSmartPropElement_SmartProp";

	/// <summary>
	/// Asset path of the Smart Prop to display
	/// </summary>
	[KV3Property("m_sSmartProp")]
	public string? SmartProp;

	/// <summary>
	/// Scale of the model, defaults to [1.0, 1.0, 1.0]
	/// </summary>
	[KV3Property("m_vModelScale")]
	public Vector3? ModelScale;

	/// <summary>
	/// The material group to use for this model
	/// </summary>
	[KV3Property("m_MaterialGroupName")]
	public string? MaterialGroupName;
}

public sealed class PlaceInSphereElement : Element
{
	public override required string Class {get; init;} = "CSmartPropElement_PlaceInSphere";
}

public sealed class PlaceMultipleElement : Element
{
	public override required string Class {get; init;} = "CSmartPropElement_PlaceMultiple";
}


public sealed class PlaceOnPathElement : Element
{
	public override required string Class {get; init;} = "CSmartPropElement_PlaceOnPath";

	/// <summary>
	/// Name of the path to use.
	/// This path name will show up in the property editor when selecting a placement of this smart prop in Hammer,
	/// allowing selection of a path object in the map to use.
	/// </summary>
	[KV3Property("m_PathName")]
	public string? PathName;

	/// <summary>
	/// Offset to apply to the path, specifies a horizontal and vertical offset to apply relative to the up direction.
	/// </summary>
	[KV3Property("m_vPathOffset")]
	public Vector3? PathOffset;

	/// <summary>
	/// Offset from the start of the path to place the first point.
	/// </summary>
	[KV3Property("m_flOffsetAlongPath")]
	public float? OffsetAlongPath;

	/// <summary>
	/// Specifies the space in which the provided input path is to be evalauted.
	/// </summary>
	[KV3Property("m_PathSpace")]
	public string? PathSpace;
}

public sealed class FitOnLineElement : Element
{
	public override required string Class {get; init;} = "CSmartPropElement_FitOnLine";

	/// <summary>
	/// Specifies the start point of the line in the specified coordinate space.
	/// </summary>
	[KV3Property("m_vStart")]
	public Vector3? Start;

	/// <summary>
	/// Specifies the end point of the line in the specified coordinate space.
	/// </summary>
	[KV3Property("m_vEnd")]
	public Vector3? End;

	// TODO:
	/// <summary>
	/// Specifies the coordinate space in which the end point values are specified.
	/// </summary>
	//[KV3Property("m_PointSpace")]
	//public string? PointSpace;

	/// <summary>
	/// Should the child elements be oriented based on the line.
	/// If enabled the child elements placed on the line will be oriented such that their +x axis points along the line towards the end point.
	/// </summary>
	[KV3Property("m_bOrientAlongLine")]
	public bool? OrientAlongLine;

	/// <summary>
	/// Up vector which is used to determine the rotation of each element around the line.
	/// </summary>
	[KV3Property("m_vUpDirection")]
	public Vector3? UpDirection;

	/// <summary>
	/// Specifies how scale is applied to each of the selected element in order to fit them to the line.
	/// </summary>
	[KV3Property("m_nScaleMode")]
	public int? ScaleMode;

	/// <summary>
	/// Child Selection Mode
	/// </summary>
	[KV3Property("m_nPickMode")]
	public int? PickMode;
}

public sealed class PickOneElement : Element
{
	public enum SelectionModeEnum
	{
		[KV3Value("RANDOM")]
		Random,
		[KV3Value("FIRST")]
		First,
	}

	public enum HandleShapeEnum
	{
		[KV3Value("SQUARE")]
		Square,
		[KV3Value("DIAMOND")]
		Diamond,
		[KV3Value("CIRCLE")]
		Circle,
	}

	public override required string Class {get; init;} = "CSmartPropElement_PickOne";

	[KV3Property("m_SelectionMode")]
	public SelectionModeEnum? SelectionMode;

	[KV3Property("m_vHandleOfffset")]
	public Vector3? HandleOffset;

	[KV3Property("m_HandleColor")]
	public Vector3? HandleColor;

	// TODO:
	//[KV3Property("m_HandleSize")]
	//public idk HandleSize

	[KV3Property("m_HandleShape")]
	public HandleShapeEnum HandleShape;
}
