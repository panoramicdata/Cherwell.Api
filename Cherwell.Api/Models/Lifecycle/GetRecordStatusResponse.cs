using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Lifecycle;

/// <summary>
/// LifecycleGetRecordStatusResponse
/// </summary>
[DataContract]
public partial class GetRecordStatusResponse : Response
{
	/// <summary>
	/// Id
	/// </summary>
	[DataMember(Name = "id", EmitDefaultValue = false)]
	public string? Id { get; set; }

	/// <summary>
	/// Name
	/// </summary>
	[DataMember(Name = "name", EmitDefaultValue = false)]
	public string? Name { get; set; }
}
