// https://developer.valvesoftware.com/wiki/Smartprop_Filters

using KeyValue3;

namespace VSmart;

public abstract class VSmartFilter : VSmartNode
{
}

/// <summary>
/// Causes the parent element to only be evaluated with a specified random probability.
/// 0.0 to 1.0 value indicating the probability of this element being evaluated.
/// Where a value of 0 means the element will never be evaluated and 1.0 means it will always be evaluated.
/// </summary>
public sealed class VSmartProbabilityFilter : VSmartFilter
{
	public override required string Class {get; init;} = "CSmartPropFilter_Probability";

	/// <summary>Probability for the filter to pass</summary>
	[KV3Property("m_flProbability")]
	public float? Probability;
}

public sealed class VSmartSurfaceAngleFilter : VSmartFilter
{
	public override required string Class {get; init;} = "CSmartPropFilter_SurfaceAngle";

	/// <summary>Minimum angle for the filter to pass</summary>
	[KV3Property("m_flSurfaceSlopeMin")]
	public float? SurfaceSlopeMin;

	/// <summary>
	/// Minimum slope on which the target will be placed.
	/// Slope is a [ 0, 180 ] value of the surface normal rotation from up
	/// such that 0 is a horizontal surface (floor), 90 is a vertical surface (wall),
	/// 180 is horizontal upside down surface (ceiling).
	/// </summary>
	[KV3Property("m_flSurfaceSlopeMax")]
	public float? SurfaceSlopeMax;
}

/// <summary>
/// Compares the current value of a variable to the specified value.
/// If the comparison is false the element evaluation is stopped.
/// </summary>
public sealed class VSmartVariableValueFilter : VSmartFilter
{
	public override required string Class {get; init;} = "CSmartPropFilter_VariableValue";
}

/// <summary>
/// Evaluates the specified expression,
/// if the result of the expression is false evaluation of the element is stopped.
/// </summary>
public sealed class VSmartExpressionFilter : VSmartFilter
{
	public override required string Class {get; init;} = "CSmartPropFilter_Expression";

	//public string? Expression;
}

/// <summary>
/// Allows the parent element to be conditionally evaluated based on surface properties.
/// </summary>
public sealed class VSmartSurfacePropertiesFilter : VSmartFilter
{
	public override required string Class { get; init; } = "CSmartPropFilter_SurfaceProperties";

	/// <summary>
	/// List of surface properties on which this element is valid.
	/// If empty element is not restricted to any specific surfaces.
	/// </summary>
	[KV3Property("m_AllowedSurfaceProperties")]
	public List<string>? AllowedSurfaceProperties;

	/// <summary>
	/// List of surface properties on which this element is not valid.
	/// If empty element is not restricted to any specific surfaces.
	/// </summary>
	[KV3Property("m_DisallowedSurfaceProperties")]
	public List<string>? DisallowedSurfaceProperties;
}
