using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Core;

/// <summary>
/// CoreLogBatchRequest
/// </summary>
[DataContract]
public partial class LogBatchRequest
{
	/// <summary>
	/// Initializes a new instance of the <see cref="LogBatchRequest" /> class.
	/// </summary>
	/// <param name="LogRequests">LogRequests.</param>
	public LogBatchRequest(List<LogRequest> LogRequests)
	{
		this.LogRequests = LogRequests;
	}

	/// <summary>
	/// LogRequests
	/// </summary>
	[DataMember(Name = "logRequests", EmitDefaultValue = false)]
	public List<LogRequest> LogRequests { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class CoreLogBatchRequest {\n");
		sb.Append("  LogRequests: ").Append(LogRequests).Append('\n');
		sb.Append("}\n");
		return sb.ToString();
	}

	/// <summary>
	/// Returns true if CoreLogBatchRequest instances are equal
	/// </summary>
	/// <param name="other">Instance of CoreLogBatchRequest to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(LogBatchRequest? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					LogRequests == other.LogRequests ||
					LogRequests != null &&
					LogRequests.SequenceEqual(other.LogRequests)
				);
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
			if (LogRequests != null)
			{
				hash = hash * 59 + LogRequests.GetHashCode();
			}

			return hash;
		}
	}

	
}
