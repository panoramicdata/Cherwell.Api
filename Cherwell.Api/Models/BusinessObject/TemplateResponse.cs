using System.Runtime.Serialization;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// TemplateResponse
/// </summary>
[DataContract]
public class TemplateResponse : Response
{
	/// <summary>
	/// Fields
	/// </summary>
	[DataMember(Name = "fields", EmitDefaultValue = false)]
	public List<FieldTemplateItem> Fields { get; set; } = null!;
}
