namespace KeyValue3;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class KV3PropertyAttribute(string propertyName) : Attribute
{
	public string PropertyName = propertyName;
}

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class KV3ValueAttribute(string v) : Attribute
{
	public string Value = v;
}
