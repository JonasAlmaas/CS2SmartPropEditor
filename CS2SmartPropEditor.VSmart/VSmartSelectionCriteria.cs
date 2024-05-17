// https://developer.valvesoftware.com/wiki/Smartprop_Selection_Criteria

using KeyValue3;

namespace CS2SmartPropEditor.VSmart;

public abstract class VSmartSelectionCriteria : VSmartNode
{
}

/// <summary>
/// Specifies the length of this element, used when fitting an element on to a line.
/// </summary>
public sealed class VSmartLinearLengthSelectionCriteria : VSmartSelectionCriteria
{
	public override required string Class {get; init;} = "CSmartPropSelectionCriteria_LinearLength";

	/// <summary>
	/// Specifies the length of the line that will be taken up if this element is selected.
	/// </summary>
	[KV3Property("m_flLength")]
	public float? Length;

	/// <summary>
	/// Can this object be scaled.
	/// If enabled the minimum and maximum lengths must be set to specify the size range of allowable scale.
	/// </summary>
	[KV3Property("m_bAllowScale")]
	public bool? AllowScale;

	/// <summary>
	/// Minimum allowable length for the object.
	/// Must be <= length. If length is 100 and minimum length is 20,
	/// then the object may be assigned a scale in the rage [ 0.2, 1.0 ]
	/// </summary>
	[KV3Property("m_flMinLength")]
	public float? MinLength;

	/// <summary>
	/// Maximum allowable length for the object. Must be >= length.
	/// If length is 100 and maximum length is 160,
	/// then the object may be assigned a scale in the rage [ 1.0, 1.6 ]
	/// </summary>
	[KV3Property("m_flMaxLength")]
	public float? MaxLength;
}

/// <summary>
/// Specifies that this is a special part that should be used at the start or end of the line.
/// </summary>
public sealed class VSmartEndCapSelectionCriteria : VSmartSelectionCriteria
{
	public override required string Class {get; init;} = "CSmartPropSelectionCriteria_EndCap";

	/// <summary>
	/// Is this an element which should be placed at the start of the line.
	/// </summary>
	[KV3Property("m_bStart")]
	public bool? Start;

	/// <summary>
	/// Is this an element which should be placed at the end of the line.
	/// </summary>
	[KV3Property("m_bEnd")]
	public bool? End;
}

/// <summary>
/// Specifies a weighting value which affects that likelyhood of selecting this element which picking a choice.
/// </summary>
public sealed class VSmartChoiceWeightSelectionCriteria : VSmartSelectionCriteria
{
	public override required string Class {get; init;} = "CSmartPropSelectionCriteria_ChoiceWeight";

	/// <summary>Selection weight</summary>
	[KV3Property("m_flWeight")]
	public float? Weight;
}

/// <summary>
/// Specifies if this element is currently valid choice.
/// </summary>
public sealed class VSmartIsValidSelectionCriteria : VSmartSelectionCriteria
{
	public override required string Class {get; init;} = "CSmartPropSelectionCriteria_IsValid";
}

/// <summary>
/// Specifies the set of positions that are valid for path placement.
/// </summary>
public sealed class VSmartPathPositionSelectionCriteria : VSmartSelectionCriteria
{
	public override required string Class {get; init;} = "CSmartPropSelectionCriteria_PathPosition";

	/// <summary>
	/// Specifies the method to use to determine which positions this element should be placed at along the path.
	/// </summary>
	[KV3Property("m_PlaceAtPositions")]
	public string? PlaceAtPositions; // "NTH", idk

	/// <summary>
	/// Specifies the spacing between positions.
	/// For example, a value of 1 will place the element at every position, 2 every other position, 3 every third position.
	/// </summary>
	[KV3Property("m_nPlaceEveryNthPosition")]
	public int? PlaceEveryNthPosition;

	/// <summary>
	/// Specifies an offset to use when determining the Nth position to place an element at.
	/// For example if placing at every third position with an offset of 0,
	/// an element will appear at positions 1, 4, 7, and so on.But if an offset of 2 is set instead of 0,
	/// then an element will appear at positions 3, 6, and 9 and so on.
	/// </summary>
	[KV3Property("m_nNthPositionIndexOffset")]
	public int? NthPositionIndexOffset;

	/// <summary>
	/// Should this element be placed at the first positions on the path.
	/// </summary>
	[KV3Property("m_bAllowAtStart")]
	public bool? AllowAtStart;

	/// <summary>
	/// Should this element be placed at the last positions on the path.
	/// </summary>
	[KV3Property("m_bAllowAtEnd")]
	public bool? AllowAtEnd;
}
