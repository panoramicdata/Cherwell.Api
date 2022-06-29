using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// BusinessObjectBarcodeLookupResponse
/// </summary>
[DataContract]
public partial class BarcodeLookupResponse : Response
{
	/// <summary>
	/// Initializes a new instance of the <see cref="BarcodeLookupResponse" /> class.
	/// </summary>
	/// <param name="busObId">BusObId.</param>
	/// <param name="busObRecId">BusObRecId.</param>
	/// <param name="errorCode">ErrorCode.</param>
	/// <param name="errorMessage">ErrorMessage.</param>
	/// <param name="hasError">HasError.</param>
	/// <param name="HttpStatusCode">HttpStatusCode.</param>
	public BarcodeLookupResponse(
		string busObId,
		string busObRecId,
		string errorCode,
		string errorMessage,
		bool hasError,
		EnumHttpStatusCode? httpStatusCode)
	{
		BusObId = busObId;
		BusObRecId = busObRecId;
		ErrorCode = errorCode;
		ErrorMessage = errorMessage;
		HasError = hasError;
		HttpStatusCode = httpStatusCode;
	}

	/// <summary>
	/// BusObId
	/// </summary>
	[DataMember(Name = "busObId", EmitDefaultValue = false)]
	public string BusObId { get; set; }

	/// <summary>
	/// BusObRecId
	/// </summary>
	[DataMember(Name = "busObRecId", EmitDefaultValue = false)]
	public string BusObRecId { get; set; }












	
}