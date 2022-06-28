using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// BusinessObjectSchemaResponse
/// </summary>
[DataContract]
public partial class SchemaResponse : Response
{
	/// <summary>
	/// Initializes a new instance of the <see cref="SchemaResponse" /> class.
	/// </summary>
	/// <param name="BusObId">BusObId.</param>
	/// <param name="fieldDefinitions">FieldDefinitions.</param>
	/// <param name="firstRecIdField">FirstRecIdField.</param>
	/// <param name="GridDefinitions">GridDefinitions.</param>
	/// <param name="Name">Name.</param>
	/// <param name="RecIdFields">RecIdFields.</param>
	/// <param name="Relationships">Relationships.</param>
	/// <param name="StateFieldId">StateFieldId.</param>
	/// <param name="states">States.</param>
	/// <param name="errorCode">ErrorCode.</param>
	/// <param name="errorMessage">ErrorMessage.</param>
	/// <param name="hasError">HasError.</param>
	/// <param name="HttpStatusCode">HttpStatusCode.</param>
	public SchemaResponse(string BusObId, List<FieldDefinition> fieldDefinitions, string firstRecIdField, List<GridDefinition> GridDefinitions, string Name, string RecIdFields, List<BusinessObjectRelationship> Relationships, string StateFieldId, string states, string errorCode, string errorMessage, bool? hasError, EnumHttpStatusCode HttpStatusCode)
	{
		this.BusObId = BusObId;
		FieldDefinitions = fieldDefinitions;
		FirstRecIdField = firstRecIdField;
		this.GridDefinitions = GridDefinitions;
		this.Name = Name;
		this.RecIdFields = RecIdFields;
		this.Relationships = Relationships;
		this.StateFieldId = StateFieldId;
		States = states;
		this.ErrorCode = errorCode;
		this.ErrorMessage = errorMessage;
		this.HasError = hasError;
		this.HttpStatusCode = HttpStatusCode;
	}

	/// <summary>
	/// BusObId
	/// </summary>
	[DataMember(Name = "busObId", EmitDefaultValue = false)]
	public string BusObId { get; set; }

	/// <summary>
	/// FieldDefinitions
	/// </summary>
	[DataMember(Name = "fieldDefinitions", EmitDefaultValue = false)]
	public List<FieldDefinition> FieldDefinitions { get; set; }

	/// <summary>
	/// FirstRecIdField
	/// </summary>
	[DataMember(Name = "firstRecIdField", EmitDefaultValue = false)]
	public string FirstRecIdField { get; set; }

	/// <summary>
	/// GridDefinitions
	/// </summary>
	[DataMember(Name = "gridDefinitions", EmitDefaultValue = false)]
	public List<GridDefinition> GridDefinitions { get; set; }

	/// <summary>
	/// Name
	/// </summary>
	[DataMember(Name = "name", EmitDefaultValue = false)]
	public string Name { get; set; }

	/// <summary>
	/// RecIdFields
	/// </summary>
	[DataMember(Name = "recIdFields", EmitDefaultValue = false)]
	public string RecIdFields { get; set; }

	/// <summary>
	/// Relationships
	/// </summary>
	[DataMember(Name = "relationships", EmitDefaultValue = false)]
	public List<BusinessObjectRelationship> Relationships { get; set; }

	/// <summary>
	/// StateFieldId
	/// </summary>
	[DataMember(Name = "stateFieldId", EmitDefaultValue = false)]
	public string StateFieldId { get; set; }

	/// <summary>
	/// States
	/// </summary>
	[DataMember(Name = "states", EmitDefaultValue = false)]
	public string States { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class BusinessObjectSchemaResponse {\n");
		sb.Append("  BusObId: ").Append(BusObId).Append('\n');
		sb.Append("  FieldDefinitions: ").Append(FieldDefinitions).Append('\n');
		sb.Append("  FirstRecIdField: ").Append(FirstRecIdField).Append('\n');
		sb.Append("  GridDefinitions: ").Append(GridDefinitions).Append('\n');
		sb.Append("  Name: ").Append(Name).Append('\n');
		sb.Append("  RecIdFields: ").Append(RecIdFields).Append('\n');
		sb.Append("  Relationships: ").Append(Relationships).Append('\n');
		sb.Append("  StateFieldId: ").Append(StateFieldId).Append('\n');
		sb.Append("  States: ").Append(States).Append('\n');
		sb.Append("  ErrorCode: ").Append(ErrorCode).Append('\n');
		sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append('\n');
		sb.Append("  HasError: ").Append(HasError).Append('\n');
		sb.Append("  HttpStatusCode: ").Append(HttpStatusCode).Append('\n');
		sb.Append("}\n");
		return sb.ToString();
	}

	/// <summary>
	/// Returns true if BusinessObjectSchemaResponse instances are equal
	/// </summary>
	/// <param name="other">Instance of BusinessObjectSchemaResponse to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(SchemaResponse? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					BusObId == other.BusObId ||
					BusObId != null &&
				BusObId.Equals(other.BusObId, StringComparison.Ordinal)
			) &&
				(
					FieldDefinitions == other.FieldDefinitions ||
					FieldDefinitions != null &&
					FieldDefinitions.SequenceEqual(other.FieldDefinitions)
				) &&
				(
					FirstRecIdField == other.FirstRecIdField ||
					FirstRecIdField != null &&
					FirstRecIdField.Equals(other.FirstRecIdField, StringComparison.Ordinal)
				) &&
				(
					GridDefinitions == other.GridDefinitions ||
					GridDefinitions != null &&
					GridDefinitions.SequenceEqual(other.GridDefinitions)
				) &&
				(
					Name == other.Name ||
					Name != null &&
					Name.Equals(other.Name, StringComparison.Ordinal)
				) &&
				(
					RecIdFields == other.RecIdFields ||
					RecIdFields != null &&
					RecIdFields.Equals(other.RecIdFields, StringComparison.Ordinal)
				) &&
				(
					Relationships == other.Relationships ||
					Relationships != null &&
					Relationships.SequenceEqual(other.Relationships)
				) &&
				(
					StateFieldId == other.StateFieldId ||
					StateFieldId != null &&
					StateFieldId.Equals(other.StateFieldId, StringComparison.Ordinal)
				) &&
				(
					States == other.States ||
					States != null &&
					States.Equals(other.States, StringComparison.Ordinal)
				) &&
				(
					ErrorCode == other.ErrorCode ||
					ErrorCode != null &&
					ErrorCode.Equals(other.ErrorCode, StringComparison.Ordinal)
				) &&
				(
					ErrorMessage == other.ErrorMessage ||
					ErrorMessage != null &&
					ErrorMessage.Equals(other.ErrorMessage, StringComparison.Ordinal)
				) &&
				(
					HasError == other.HasError ||
					HasError != null &&
					HasError.Equals(other.HasError)
				) &&
				(
					HttpStatusCode == other.HttpStatusCode ||
					HttpStatusCode != null &&
					HttpStatusCode.Equals(other.HttpStatusCode)
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
			if (BusObId != null)
			{
				hash = hash * 59 + BusObId.GetHashCode();
			}

			if (FieldDefinitions != null)
			{
				hash = hash * 59 + FieldDefinitions.GetHashCode();
			}

			if (FirstRecIdField != null)
			{
				hash = hash * 59 + FirstRecIdField.GetHashCode();
			}

			if (GridDefinitions != null)
			{
				hash = hash * 59 + GridDefinitions.GetHashCode();
			}

			if (Name != null)
			{
				hash = hash * 59 + Name.GetHashCode();
			}

			if (RecIdFields != null)
			{
				hash = hash * 59 + RecIdFields.GetHashCode();
			}

			if (Relationships != null)
			{
				hash = hash * 59 + Relationships.GetHashCode();
			}

			if (StateFieldId != null)
			{
				hash = hash * 59 + StateFieldId.GetHashCode();
			}

			if (States != null)
			{
				hash = hash * 59 + States.GetHashCode();
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