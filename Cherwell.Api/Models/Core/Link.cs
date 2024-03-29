using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Core;

/// <summary>
/// Link
/// </summary>
[DataContract]
public class Link
{
	/// <summary>
	/// Name
	/// </summary>
	[DataMember(Name = "name", EmitDefaultValue = false)]
	public string Name { get; set; } = null!;

	/// <summary>
	/// Url
	/// </summary>
	[DataMember(Name = "url", EmitDefaultValue = false)]
	public string Url { get; set; } = null!;
}
