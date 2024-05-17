namespace CS2SmartPropEditor.SmartProject;

public class SmartProject
{
	public static readonly string Extension = ".smartproj";

	public static readonly int Version = 1;

	public required string Name;
}

public class SmartProjectSerilizer
{
	public static Stream Serialize(SmartProject project) {
		throw new NotImplementedException();
	}
}

public class SmartProjectParser
{
	public static SmartProject Parse(Stream stream) {
		throw new NotImplementedException();
	}
}
