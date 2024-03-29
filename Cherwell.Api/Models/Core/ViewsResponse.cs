using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Core;


/// <summary>
/// ViewsResponse
/// </summary>
[DataContract]
public class ViewsResponse : Response
{
	/// <summary>
	/// Views
	/// </summary>
	[DataMember(Name = "views", EmitDefaultValue = false)]
	public List<View> Views { get; set; } = null!;
}
