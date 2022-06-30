using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// BusinessObjectFieldValuesLookupResponse
/// </summary>
[DataContract]
public partial class FieldValuesLookupResponse : Response
{
	/// <summary>
	/// Values
	/// </summary>
	[DataMember(Name = "values", EmitDefaultValue = false)]
	public List<string>? Values { get; set; }
}