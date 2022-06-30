using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Core;


/// <summary>
/// CoreViewsResponse
/// </summary>
[DataContract]
public partial class ViewsResponse : Response
{
	/// <summary>
	/// Views
	/// </summary>
	[DataMember(Name = "views", EmitDefaultValue = false)]
	public List<View>? Views { get; set; }
}
