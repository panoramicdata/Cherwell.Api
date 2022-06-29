using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Teams;

/// <summary>
/// TeamsResponse
/// </summary>
[DataContract]
public partial class TeamsResponse : Response
{
	/// <summary>
	/// Initializes a new instance of the <see cref="TeamsResponse" /> class.
	/// </summary>
	/// <param name="Error">Error.</param>
	/// <param name="ErrorCode">ErrorCode.</param>
	/// <param name="HasError">HasError.</param>
	/// <param name="Teams">Teams.</param>
	public TeamsResponse(string error, string errorCode, bool? hasError, List<Team> Teams)
	{
		this.Error = error;
		this.ErrorCode = errorCode;
		this.HasError = hasError;
		this.Teams = Teams;
	}

	/// <summary>
	/// Error
	/// </summary>
	[DataMember(Name = "error", EmitDefaultValue = false)]
	public string Error { get; set; }

	/// <summary>
	/// Teams
	/// </summary>
	[DataMember(Name = "teams", EmitDefaultValue = false)]
	public List<Team> Teams { get; set; }








	/// <summary>
	/// Gets the hash code
	/// </summary>
	/// <returns>Hash code</returns>
	public override int GetHashCode()
	{
		// credit: http://stackoverflow.com/a/263416/677735
		unchecked // Overflow is fine, just wrap
		{
			int hash = 41;
			// Suitable nullity checks etc, of course :)


		}
	}

	
}

