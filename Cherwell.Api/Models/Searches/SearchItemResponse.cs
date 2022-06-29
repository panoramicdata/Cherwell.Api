using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesSearchItemResponse
/// </summary>
[DataContract]
public partial class SearchItemResponse : Response
{
	/// <summary>
	/// Initializes a new instance of the <see cref="SearchItemResponse" /> class.
	/// </summary>
	/// <param name="Root">Root.</param>
	/// <param name="SupportedAssociations">SupportedAssociations.</param>
	/// <param name="errorCode">ErrorCode.</param>
	/// <param name="errorMessage">ErrorMessage.</param>
	/// <param name="hasError">HasError.</param>
	/// <param name="HttpStatusCode">HttpStatusCode.</param>
	public SearchItemResponse(SearchFolder Root, List<Association> SupportedAssociations, string errorCode, string errorMessage, bool? hasError, EnumHttpStatusCode HttpStatusCode)
	{
		this.Root = Root;
		this.SupportedAssociations = SupportedAssociations;
		this.ErrorCode = errorCode;
		this.ErrorMessage = errorMessage;
		this.HasError = hasError;
		this.HttpStatusCode = HttpStatusCode;
	}

	/// <summary>
	/// Root
	/// </summary>
	[DataMember(Name = "root", EmitDefaultValue = false)]
	public SearchFolder Root { get; set; }

	/// <summary>
	/// SupportedAssociations
	/// </summary>
	[DataMember(Name = "supportedAssociations", EmitDefaultValue = false)]
	public List<Association> SupportedAssociations { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class SearchesSearchItemResponse {\n");
		sb.Append("  Root: ").Append(Root).Append('\n');
		sb.Append("  SupportedAssociations: ").Append(SupportedAssociations).Append('\n');
		sb.Append("  ErrorCode: ").Append(ErrorCode).Append('\n');
		sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append('\n');
		sb.Append("  HasError: ").Append(HasError).Append('\n');
		sb.Append("  HttpStatusCode: ").Append(HttpStatusCode).Append('\n');
		sb.Append("}\n");
		return sb.ToString();
	}

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
			if (Root != null)
			{
				hash = hash * 59 + Root.GetHashCode();
			}

			if (SupportedAssociations != null)
			{
				hash = hash * 59 + SupportedAssociations.GetHashCode();
			}

			if (ErrorCode != null)
			{
				hash = hash * 59 + ErrorCode.GetHashCode();
			}

			if (ErrorMessage != null)
			{
				hash = hash * 59 + ErrorMessage.GetHashCode();
			}

			if (HasError != null)
			{
				hash = hash * 59 + HasError.GetHashCode();
			}

			if (HttpStatusCode != null)
			{
				hash = hash * 59 + HttpStatusCode.GetHashCode();
			}

			return hash;
		}
	}

	
}
