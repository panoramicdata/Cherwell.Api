using System.Runtime.Serialization;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// FieldValuesLookupResponse
/// </summary>
[DataContract]
public class FieldValuesLookupResponse : Response
{
	/// <summary>
	/// Values
	/// </summary>
	[DataMember(Name = "values", EmitDefaultValue = false)]
	public List<string> Values { get; set; } = null!;
}