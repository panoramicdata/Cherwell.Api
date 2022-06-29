using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Teams;

/// <summary>
/// TeamsV2Response
/// </summary>
[DataContract]
public partial class TeamsV2Response : Response
{
	/// <summary>
	/// Initializes a new instance of the <see cref="TeamsV2Response" /> class.
	/// </summary>
	/// <param name="Teams">Teams.</param>
	/// <param name="errorCode">ErrorCode.</param>
	/// <param name="errorMessage">ErrorMessage.</param>
	/// <param name="hasError">HasError.</param>
	/// <param name="HttpStatusCode">HttpStatusCode.</param>
	public TeamsV2Response(List<Team> Teams, string errorCode, string errorMessage, bool? hasError, EnumHttpStatusCode HttpStatusCode)
	{
		this.Teams = Teams;
		this.ErrorCode = errorCode;
		this.ErrorMessage = errorMessage;
		this.HasError = hasError;
		this.HttpStatusCode = HttpStatusCode;
	}

	/// <summary>
	/// Teams
	/// </summary>
	[DataMember(Name = "teams", EmitDefaultValue = false)]
	public List<Team> Teams { get; set; }











	
}

