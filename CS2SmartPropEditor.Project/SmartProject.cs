using System.Text.Json;
using System.Text.Json.Serialization;

namespace CS2SmartPropEditor.Project;

public class SmartProjectSerializer
{
	private static readonly JsonSerializerOptions serializerOptions = new () {
		WriteIndented = true,
		IncludeFields = true,
		DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
		Converters = {
			new JsonStringEnumConverter(JsonNamingPolicy.CamelCase)
		}
	};

	public static string Serialize(SmartProject project) {
		return JsonSerializer.Serialize(project, serializerOptions);
	}

	public static SmartProject? Deserialize(string fPath) {
		try {
			var content = File.ReadAllText(fPath);
			return JsonSerializer.Deserialize<SmartProject>(content, serializerOptions);
		} catch {
			Console.WriteLine($"Failed to deserialize SmartProject file \"{fPath}\"");
			return null;
		}
	}
}

public class SmartProject
{
	public static readonly string Extension = ".smartproj";

	public readonly int FormatVersion = 1;
	public required string ProjectName;
	public required string AddonName;
	public required List<ProjectSmartProp> SmartProps;
}

public class ProjectSmartProp
{
	public string? Description;
	/// <summary>Relative path from addon root</summary>
	public required string Path;
	public List<ProjectSmartPropVariable>? Variables;
}

public class ProjectSmartPropVariable
{

}
