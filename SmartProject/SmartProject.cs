namespace SmartProject;

public class SmartProject
{
	public static readonly string extension = ".vsmartproj";
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
