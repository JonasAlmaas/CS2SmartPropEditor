// https://developer.valvesoftware.com/wiki/Counter-Strike_2_Workshop_Tools/Level_Design/Smartprops

using KeyValue3;

namespace CS2SmartPropEditor.VSmart;

public abstract class VSmartNode
{
	[KV3Property("_class")]
	public virtual required string Class {get; init;}

	[KV3Property("m_nElementID")]
	public int ElementId;
}
