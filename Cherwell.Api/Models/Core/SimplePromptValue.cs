using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Core;

/// <summary>
/// CoreSimplePromptValue
/// </summary>
[DataContract]
public partial class SimplePromptValue
{
	/// <summary>
	/// PromptDefId
	/// </summary>
	[DataMember(Name = "promptDefId", EmitDefaultValue = false)]
	public string? PromptDefId { get; set; }

	/// <summary>
	/// PromptName
	/// </summary>
	[DataMember(Name = "promptName", EmitDefaultValue = false)]
	public string? PromptName { get; set; }

	/// <summary>
	/// Value
	/// </summary>
	[DataMember(Name = "value", EmitDefaultValue = false)]
	public string? Value { get; set; }
}
