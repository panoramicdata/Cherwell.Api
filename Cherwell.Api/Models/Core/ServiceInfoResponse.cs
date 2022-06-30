using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Core;

/// <summary>
/// ServiceInfoResponse
/// </summary>
[DataContract]
public partial class ServiceInfoResponse : Response
{
	/// <summary>
	/// ApiVersion
	/// </summary>
	[DataMember(Name = "apiVersion", EmitDefaultValue = false)]
	public string ApiVersion { get; set; } = null!;

	/// <summary>
	/// CsmCulture
	/// </summary>
	[DataMember(Name = "csmCulture", EmitDefaultValue = false)]
	public string CsmCulture { get; set; } = null!;

	/// <summary>
	/// CsmVersion
	/// </summary>
	[DataMember(Name = "csmVersion", EmitDefaultValue = false)]
	public string CsmVersion { get; set; } = null!;

	/// <summary>
	/// SystemDateTime
	/// </summary>
	[DataMember(Name = "systemDateTime", EmitDefaultValue = false)]
	public DateTime SystemDateTime { get; set; }

	/// <summary>
	/// TimeZone
	/// </summary>
	[DataMember(Name = "timeZone", EmitDefaultValue = false)]
	public Object TimeZone { get; set; } = null!;

	/// <summary>
	/// SystemUtcOffset
	/// </summary>
	[DataMember(Name = "systemUtcOffset", EmitDefaultValue = false)]
	public string SystemUtcOffset { get; set; } = null!;
}
