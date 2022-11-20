using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Core;

/// <summary>
/// SimplePromptValue
/// </summary>
[DataContract]
public class SimplePromptValue
{
	/// <summary>
	/// PromptDefId
	/// </summary>
	[DataMember(Name = "promptDefId", EmitDefaultValue = false)]
	public string PromptDefId { get; set; } = null!;

	/// <summary>
	/// PromptName
	/// </summary>
	[DataMember(Name = "promptName", EmitDefaultValue = false)]
	public string PromptName { get; set; } = null!;

	/// <summary>
	/// Value
	/// </summary>
	[DataMember(Name = "value", EmitDefaultValue = false)]
	public string Value { get; set; } = null!;
}
