using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Lifecycle;

/// <summary>
/// LifecycleGetTransitionsResponseTransition
/// </summary>
[DataContract]
public partial class GetTransitionsResponseTransition
{
	/// <summary>
	/// Initializes a new instance of the <see cref="GetTransitionsResponseTransition" /> class.
	/// </summary>
	/// <param name="Id">Id.</param>
	/// <param name="Name">Name.</param>
	/// <param name="FromStatusId">FromStatusId.</param>
	/// <param name="ToStatusId">ToStatusId.</param>
	public GetTransitionsResponseTransition(string Id, string Name, string FromStatusId, string ToStatusId)
	{
		this.Id = Id;
		this.Name = Name;
		this.FromStatusId = FromStatusId;
		this.ToStatusId = ToStatusId;
	}

	/// <summary>
	/// Id
	/// </summary>
	[DataMember(Name = "id", EmitDefaultValue = false)]
	public string Id { get; set; }

	/// <summary>
	/// Name
	/// </summary>
	[DataMember(Name = "name", EmitDefaultValue = false)]
	public string Name { get; set; }

	/// <summary>
	/// FromStatusId
	/// </summary>
	[DataMember(Name = "fromStatusId", EmitDefaultValue = false)]
	public string FromStatusId { get; set; }

	/// <summary>
	/// ToStatusId
	/// </summary>
	[DataMember(Name = "toStatusId", EmitDefaultValue = false)]
	public string ToStatusId { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class LifecycleGetTransitionsResponseTransition {\n");
		sb.Append("  Id: ").Append(Id).Append('\n');
		sb.Append("  Name: ").Append(Name).Append('\n');
		sb.Append("  FromStatusId: ").Append(FromStatusId).Append('\n');
		sb.Append("  ToStatusId: ").Append(ToStatusId).Append('\n');
		sb.Append("}\n");
		return sb.ToString();
	}

	/// <summary>
	/// Returns true if LifecycleGetTransitionsResponseTransition instances are equal
	/// </summary>
	/// <param name="other">Instance of LifecycleGetTransitionsResponseTransition to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(GetTransitionsResponseTransition? other)
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
					Name == other.Name ||
					Name != null &&
					Name.Equals(other.Name, StringComparison.Ordinal)
				) &&
				(
					FromStatusId == other.FromStatusId ||
					FromStatusId != null &&
					FromStatusId.Equals(other.FromStatusId, StringComparison.Ordinal)
				) &&
				(
					ToStatusId == other.ToStatusId ||
					ToStatusId != null &&
					ToStatusId.Equals(other.ToStatusId, StringComparison.Ordinal)
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

			if (Name != null)
			{
				hash = hash * 59 + Name.GetHashCode();
			}

			if (FromStatusId != null)
			{
				hash = hash * 59 + FromStatusId.GetHashCode();
			}

			if (ToStatusId != null)
			{
				hash = hash * 59 + ToStatusId.GetHashCode();
			}

			return hash;
		}
	}

	
}
