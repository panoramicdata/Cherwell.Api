using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Core;

/// <summary>
/// CoreAction
/// </summary>
[DataContract]
public partial class Action : IEquatable<Action>, IValidatableObject
{
	/// <summary>
	/// ActionType
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum EnumActionType
	{

		/// <summary>
		/// Enum None for "None"
		/// </summary>
		[EnumMember(Value = "None")]
		None,

		/// <summary>
		/// Enum OneStep for "OneStep"
		/// </summary>
		[EnumMember(Value = "OneStep")]
		OneStep,

		/// <summary>
		/// Enum Command for "Command"
		/// </summary>
		[EnumMember(Value = "Command")]
		Command,

		/// <summary>
		/// Enum BuiltIn for "BuiltIn"
		/// </summary>
		[EnumMember(Value = "BuiltIn")]
		BuiltIn,

		/// <summary>
		/// Enum Category for "Category"
		/// </summary>
		[EnumMember(Value = "Category")]
		Category,

		/// <summary>
		/// Enum SearchGrp for "SearchGrp"
		/// </summary>
		[EnumMember(Value = "SearchGrp")]
		SearchGrp,

		/// <summary>
		/// Enum Report for "Report"
		/// </summary>
		[EnumMember(Value = "Report")]
		Report,

		/// <summary>
		/// Enum Dashboard for "Dashboard"
		/// </summary>
		[EnumMember(Value = "Dashboard")]
		Dashboard,

		/// <summary>
		/// Enum Calendar for "Calendar"
		/// </summary>
		[EnumMember(Value = "Calendar")]
		Calendar,

		/// <summary>
		/// Enum Visualization for "Visualization"
		/// </summary>
		[EnumMember(Value = "Visualization")]
		Visualization,

		/// <summary>
		/// Enum Group for "Group"
		/// </summary>
		[EnumMember(Value = "Group")]
		Group,

		/// <summary>
		/// Enum Page for "Page"
		/// </summary>
		[EnumMember(Value = "Page")]
		Page,

		/// <summary>
		/// Enum DocRepository for "DocRepository"
		/// </summary>
		[EnumMember(Value = "DocRepository")]
		DocRepository,

		/// <summary>
		/// Enum PortalCommand for "PortalCommand"
		/// </summary>
		[EnumMember(Value = "PortalCommand")]
		PortalCommand,

		/// <summary>
		/// Enum ActionCatalog for "ActionCatalog"
		/// </summary>
		[EnumMember(Value = "ActionCatalog")]
		ActionCatalog,

		/// <summary>
		/// Enum OneStepForRecord for "OneStepForRecord"
		/// </summary>
		[EnumMember(Value = "OneStepForRecord")]
		OneStepForRecord
	}

	/// <summary>
	/// LoginEnabledMode
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum EnumLoginEnabledMode
	{

		/// <summary>
		/// Enum Anonymous for "Anonymous"
		/// </summary>
		[EnumMember(Value = "Anonymous")]
		Anonymous,

		/// <summary>
		/// Enum LoggedIn for "LoggedIn"
		/// </summary>
		[EnumMember(Value = "LoggedIn")]
		LoggedIn,

		/// <summary>
		/// Enum Both for "Both"
		/// </summary>
		[EnumMember(Value = "Both")]
		Both
	}

	/// <summary>
	/// LoginVisibilityMode
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum EnumLoginVisibilityMode
	{

		/// <summary>
		/// Enum Anonymous for "Anonymous"
		/// </summary>
		[EnumMember(Value = "Anonymous")]
		Anonymous,

		/// <summary>
		/// Enum LoggedIn for "LoggedIn"
		/// </summary>
		[EnumMember(Value = "LoggedIn")]
		LoggedIn,

		/// <summary>
		/// Enum Both for "Both"
		/// </summary>
		[EnumMember(Value = "Both")]
		Both
	}

	/// <summary>
	/// ActionType
	/// </summary>
	[DataMember(Name = "actionType", EmitDefaultValue = false)]
	public EnumActionType? ActionType { get; set; }

	/// <summary>
	/// LoginEnabledMode
	/// </summary>
	[DataMember(Name = "loginEnabledMode", EmitDefaultValue = false)]
	public EnumLoginEnabledMode? LoginEnabledMode { get; set; }

	/// <summary>
	/// LoginVisibilityMode
	/// </summary>
	[DataMember(Name = "loginVisibilityMode", EmitDefaultValue = false)]
	public EnumLoginVisibilityMode? LoginVisibilityMode { get; set; }

	/// <summary>
	/// Initializes a new instance of the <see cref="Action" /> class.
	/// </summary>
	/// <param name="ActionCommand">ActionCommand.</param>
	/// <param name="ActionType">ActionType.</param>
	/// <param name="AlwaysTextAndImage">AlwaysTextAndImage.</param>
	/// <param name="BeginGroup">BeginGroup.</param>
	/// <param name="ChildActions">ChildActions.</param>
	/// <param name="Dependencies">Dependencies.</param>
	/// <param name="DisplayText">DisplayText.</param>
	/// <param name="Enabled">Enabled.</param>
	/// <param name="GalleryImage">GalleryImage.</param>
	/// <param name="HelpText">HelpText.</param>
	/// <param name="LoginEnabledMode">LoginEnabledMode.</param>
	/// <param name="LoginVisibilityMode">LoginVisibilityMode.</param>
	/// <param name="Name">Name.</param>
	/// <param name="Parameters">Parameters.</param>
	/// <param name="Visible">Visible.</param>
	public Action(string ActionCommand, EnumActionType? ActionType, bool? AlwaysTextAndImage, bool? BeginGroup, List<Action> ChildActions, List<string> Dependencies, string DisplayText, bool? Enabled, string GalleryImage, string HelpText, EnumLoginEnabledMode? LoginEnabledMode, EnumLoginVisibilityMode? LoginVisibilityMode, string Name, Dictionary<string, string> Parameters, bool? Visible)
	{
		this.ActionCommand = ActionCommand;
		this.ActionType = ActionType;
		this.AlwaysTextAndImage = AlwaysTextAndImage;
		this.BeginGroup = BeginGroup;
		this.ChildActions = ChildActions;
		this.Dependencies = Dependencies;
		this.DisplayText = DisplayText;
		this.Enabled = Enabled;
		this.GalleryImage = GalleryImage;
		this.HelpText = HelpText;
		this.LoginEnabledMode = LoginEnabledMode;
		this.LoginVisibilityMode = LoginVisibilityMode;
		this.Name = Name;
		this.Parameters = Parameters;
		this.Visible = Visible;
	}

	/// <summary>
	/// ActionCommand
	/// </summary>
	[DataMember(Name = "actionCommand", EmitDefaultValue = false)]
	public string ActionCommand { get; set; }

	/// <summary>
	/// AlwaysTextAndImage
	/// </summary>
	[DataMember(Name = "alwaysTextAndImage", EmitDefaultValue = false)]
	public bool? AlwaysTextAndImage { get; set; }

	/// <summary>
	/// BeginGroup
	/// </summary>
	[DataMember(Name = "beginGroup", EmitDefaultValue = false)]
	public bool? BeginGroup { get; set; }

	/// <summary>
	/// ChildActions
	/// </summary>
	[DataMember(Name = "childActions", EmitDefaultValue = false)]
	public List<Action> ChildActions { get; set; }

	/// <summary>
	/// Dependencies
	/// </summary>
	[DataMember(Name = "dependencies", EmitDefaultValue = false)]
	public List<string> Dependencies { get; set; }

	/// <summary>
	/// DisplayText
	/// </summary>
	[DataMember(Name = "displayText", EmitDefaultValue = false)]
	public string DisplayText { get; set; }

	/// <summary>
	/// Enabled
	/// </summary>
	[DataMember(Name = "enabled", EmitDefaultValue = false)]
	public bool? Enabled { get; set; }

	/// <summary>
	/// GalleryImage
	/// </summary>
	[DataMember(Name = "galleryImage", EmitDefaultValue = false)]
	public string GalleryImage { get; set; }

	/// <summary>
	/// HelpText
	/// </summary>
	[DataMember(Name = "helpText", EmitDefaultValue = false)]
	public string HelpText { get; set; }

	/// <summary>
	/// Name
	/// </summary>
	[DataMember(Name = "name", EmitDefaultValue = false)]
	public string Name { get; set; }

	/// <summary>
	/// Parameters
	/// </summary>
	[DataMember(Name = "parameters", EmitDefaultValue = false)]
	public Dictionary<string, string> Parameters { get; set; }

	/// <summary>
	/// Visible
	/// </summary>
	[DataMember(Name = "visible", EmitDefaultValue = false)]
	public bool? Visible { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class CoreAction {\n");
		sb.Append("  ActionCommand: ").Append(ActionCommand).Append('\n');
		sb.Append("  ActionType: ").Append(ActionType).Append('\n');
		sb.Append("  AlwaysTextAndImage: ").Append(AlwaysTextAndImage).Append('\n');
		sb.Append("  BeginGroup: ").Append(BeginGroup).Append('\n');
		sb.Append("  ChildActions: ").Append(ChildActions).Append('\n');
		sb.Append("  Dependencies: ").Append(Dependencies).Append('\n');
		sb.Append("  DisplayText: ").Append(DisplayText).Append('\n');
		sb.Append("  Enabled: ").Append(Enabled).Append('\n');
		sb.Append("  GalleryImage: ").Append(GalleryImage).Append('\n');
		sb.Append("  HelpText: ").Append(HelpText).Append('\n');
		sb.Append("  LoginEnabledMode: ").Append(LoginEnabledMode).Append('\n');
		sb.Append("  LoginVisibilityMode: ").Append(LoginVisibilityMode).Append('\n');
		sb.Append("  Name: ").Append(Name).Append('\n');
		sb.Append("  Parameters: ").Append(Parameters).Append('\n');
		sb.Append("  Visible: ").Append(Visible).Append('\n');
		sb.Append("}\n");
		return sb.ToString();
	}

	/// <summary>
	/// Returns the JSON string presentation of the object
	/// </summary>
	/// <returns>JSON string presentation of the object</returns>
	public string ToJson()
	{
		return JsonConvert.SerializeObject(this, Formatting.Indented);
	}

	/// <summary>
	/// Returns true if objects are equal
	/// </summary>
	/// <param name="obj">Object to be compared</param>
	/// <returns>Boolean</returns>
	public override bool Equals(object? obj)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		return Equals(obj as Action);
	}

	/// <summary>
	/// Returns true if CoreAction instances are equal
	/// </summary>
	/// <param name="other">Instance of CoreAction to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(Action? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					ActionCommand == other.ActionCommand ||
					ActionCommand != null &&
					ActionCommand.Equals(other.ActionCommand, StringComparison.Ordinal)
				) &&
				(
					ActionType == other.ActionType ||
					ActionType != null &&
					ActionType.Equals(other.ActionType)
				) &&
				(
					AlwaysTextAndImage == other.AlwaysTextAndImage ||
					AlwaysTextAndImage != null &&
					AlwaysTextAndImage.Equals(other.AlwaysTextAndImage)
				) &&
				(
					BeginGroup == other.BeginGroup ||
					BeginGroup != null &&
					BeginGroup.Equals(other.BeginGroup)
				) &&
				(
					ChildActions == other.ChildActions ||
					ChildActions != null &&
					ChildActions.SequenceEqual(other.ChildActions)
				) &&
				(
					Dependencies == other.Dependencies ||
					Dependencies != null &&
					Dependencies.SequenceEqual(other.Dependencies)
				) &&
				(
					DisplayText == other.DisplayText ||
					DisplayText != null &&
					DisplayText.Equals(other.DisplayText, StringComparison.Ordinal)
				) &&
				(
					Enabled == other.Enabled ||
					Enabled != null &&
					Enabled.Equals(other.Enabled)
				) &&
				(
					GalleryImage == other.GalleryImage ||
					GalleryImage != null &&
					GalleryImage.Equals(other.GalleryImage, StringComparison.Ordinal)
				) &&
				(
					HelpText == other.HelpText ||
					HelpText != null &&
					HelpText.Equals(other.HelpText, StringComparison.Ordinal)
				) &&
				(
					LoginEnabledMode == other.LoginEnabledMode ||
					LoginEnabledMode != null &&
					LoginEnabledMode.Equals(other.LoginEnabledMode)
				) &&
				(
					LoginVisibilityMode == other.LoginVisibilityMode ||
					LoginVisibilityMode != null &&
					LoginVisibilityMode.Equals(other.LoginVisibilityMode)
				) &&
				(
					Name == other.Name ||
					Name != null &&
					Name.Equals(other.Name, StringComparison.Ordinal)
				) &&
				(
					Parameters == other.Parameters ||
					Parameters != null &&
					Parameters.SequenceEqual(other.Parameters)
				) &&
				(
					Visible == other.Visible ||
					Visible != null &&
					Visible.Equals(other.Visible)
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
			if (ActionCommand != null)
			{
				hash = hash * 59 + ActionCommand.GetHashCode();
			}

			if (ActionType != null)
			{
				hash = hash * 59 + ActionType.GetHashCode();
			}

			if (AlwaysTextAndImage != null)
			{
				hash = hash * 59 + AlwaysTextAndImage.GetHashCode();
			}

			if (BeginGroup != null)
			{
				hash = hash * 59 + BeginGroup.GetHashCode();
			}

			if (ChildActions != null)
			{
				hash = hash * 59 + ChildActions.GetHashCode();
			}

			if (Dependencies != null)
			{
				hash = hash * 59 + Dependencies.GetHashCode();
			}

			if (DisplayText != null)
			{
				hash = hash * 59 + DisplayText.GetHashCode();
			}

			if (Enabled != null)
			{
				hash = hash * 59 + Enabled.GetHashCode();
			}

			if (GalleryImage != null)
			{
				hash = hash * 59 + GalleryImage.GetHashCode();
			}

			if (HelpText != null)
			{
				hash = hash * 59 + HelpText.GetHashCode();
			}

			if (LoginEnabledMode != null)
			{
				hash = hash * 59 + LoginEnabledMode.GetHashCode();
			}

			if (LoginVisibilityMode != null)
			{
				hash = hash * 59 + LoginVisibilityMode.GetHashCode();
			}

			if (Name != null)
			{
				hash = hash * 59 + Name.GetHashCode();
			}

			if (Parameters != null)
			{
				hash = hash * 59 + Parameters.GetHashCode();
			}

			if (Visible != null)
			{
				hash = hash * 59 + Visible.GetHashCode();
			}

			return hash;
		}
	}

	/// <summary>
	/// To validate all properties of the instance
	/// </summary>
	/// <param name="validationContext">Validation context</param>
	/// <returns>Validation Result</returns>
	IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
	{
		yield break;
	}
}
