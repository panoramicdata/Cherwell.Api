using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Lifecycle;

/// <summary>
/// LifecycleGetStatusesResponseStatuses
/// </summary>
[DataContract]
public partial class GetStatusesResponseStatuses
{
	/// <summary>
	/// Initializes a new instance of the <see cref="GetStatusesResponseStatuses" /> class.
	/// </summary>
	/// <param name="Id">Id.</param>
	/// <param name="IsInitial">IsInitial.</param>
	/// <param name="Name">Name.</param>
	/// <param name="StageId">StageId.</param>
	public GetStatusesResponseStatuses(string Id, bool? IsInitial, string Name, string StageId)
	{
		this.Id = Id;
		this.IsInitial = IsInitial;
		this.Name = Name;
		this.StageId = StageId;
	}

	/// <summary>
	/// Id
	/// </summary>
	[DataMember(Name = "id", EmitDefaultValue = false)]
	public string Id { get; set; }

	/// <summary>
	/// IsInitial
	/// </summary>
	[DataMember(Name = "isInitial", EmitDefaultValue = false)]
	public bool? IsInitial { get; set; }

	/// <summary>
	/// Name
	/// </summary>
	[DataMember(Name = "name", EmitDefaultValue = false)]
	public string Name { get; set; }

	/// <summary>
	/// StageId
	/// </summary>
	[DataMember(Name = "stageId", EmitDefaultValue = false)]
	public string StageId { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class LifecycleGetStatusesResponseStatuses {\n");
		sb.Append("  Id: ").Append(Id).Append('\n');
		sb.Append("  IsInitial: ").Append(IsInitial).Append('\n');
		sb.Append("  Name: ").Append(Name).Append('\n');
		sb.Append("  StageId: ").Append(StageId).Append('\n');
		sb.Append("}\n");
		return sb.ToString();
	}

	/// <summary>
	/// Returns true if LifecycleGetStatusesResponseStatuses instances are equal
	/// </summary>
	/// <param name="other">Instance of LifecycleGetStatusesResponseStatuses to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(GetStatusesResponseStatuses? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					Id == other.Id ||
					Id != null &&
					Id.Equals(other.Id, StringComparison.Ordinal)
				) &&
				(
					IsInitial == other.IsInitial ||
					IsInitial != null &&
					IsInitial.Equals(other.IsInitial)
				) &&
				(
					Name == other.Name ||
					Name != null &&
					Name.Equals(other.Name, StringComparison.Ordinal)
				) &&
				(
					StageId == other.StageId ||
					StageId != null &&
					StageId.Equals(other.StageId, StringComparison.Ordinal)
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
			if (Id != null)
			{
				hash = hash * 59 + Id.GetHashCode();
			}

			if (IsInitial != null)
			{
				hash = hash * 59 + IsInitial.GetHashCode();
			}

			if (Name != null)
			{
				hash = hash * 59 + Name.GetHashCode();
			}

			if (StageId != null)
			{
				hash = hash * 59 + StageId.GetHashCode();
			}

			return hash;
		}
	}

	
}
