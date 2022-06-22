using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Cherwell.Api.Model.Core
{
    /// <summary>
    /// CoreAction
    /// </summary>
    [DataContract]
    public partial class CoreAction : IEquatable<CoreAction>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ActionType
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
        /// Gets or Sets LoginEnabledMode
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
        /// Gets or Sets LoginVisibilityMode
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
        /// Gets or Sets ActionType
        /// </summary>
        [DataMember(Name = "actionType", EmitDefaultValue = false)]
        public EnumActionType? ActionType { get; set; }
        /// <summary>
        /// Gets or Sets LoginEnabledMode
        /// </summary>
        [DataMember(Name = "loginEnabledMode", EmitDefaultValue = false)]
        public EnumLoginEnabledMode? LoginEnabledMode { get; set; }
        /// <summary>
        /// Gets or Sets LoginVisibilityMode
        /// </summary>
        [DataMember(Name = "loginVisibilityMode", EmitDefaultValue = false)]
        public EnumLoginVisibilityMode? LoginVisibilityMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CoreAction" /> class.
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
        public CoreAction(string ActionCommand = default, EnumActionType? ActionType = default(EnumActionType?), bool? AlwaysTextAndImage = default(bool?), bool? BeginGroup = default(bool?), List<CoreAction> ChildActions = default(List<CoreAction>), List<string> Dependencies = default(List<string>), string DisplayText = default, bool? Enabled = default(bool?), string GalleryImage = default, string HelpText = default, EnumLoginEnabledMode? LoginEnabledMode = default(EnumLoginEnabledMode?), EnumLoginVisibilityMode? LoginVisibilityMode = default(EnumLoginVisibilityMode?), string Name = default, Dictionary<string, string> Parameters = default(Dictionary<string, string>), bool? Visible = default(bool?))
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
        /// Gets or Sets ActionCommand
        /// </summary>
        [DataMember(Name = "actionCommand", EmitDefaultValue = false)]
        public string ActionCommand { get; set; }
        /// <summary>
        /// Gets or Sets AlwaysTextAndImage
        /// </summary>
        [DataMember(Name = "alwaysTextAndImage", EmitDefaultValue = false)]
        public bool? AlwaysTextAndImage { get; set; }
        /// <summary>
        /// Gets or Sets BeginGroup
        /// </summary>
        [DataMember(Name = "beginGroup", EmitDefaultValue = false)]
        public bool? BeginGroup { get; set; }
        /// <summary>
        /// Gets or Sets ChildActions
        /// </summary>
        [DataMember(Name = "childActions", EmitDefaultValue = false)]
        public List<CoreAction> ChildActions { get; set; }
        /// <summary>
        /// Gets or Sets Dependencies
        /// </summary>
        [DataMember(Name = "dependencies", EmitDefaultValue = false)]
        public List<string> Dependencies { get; set; }
        /// <summary>
        /// Gets or Sets DisplayText
        /// </summary>
        [DataMember(Name = "displayText", EmitDefaultValue = false)]
        public string DisplayText { get; set; }
        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name = "enabled", EmitDefaultValue = false)]
        public bool? Enabled { get; set; }
        /// <summary>
        /// Gets or Sets GalleryImage
        /// </summary>
        [DataMember(Name = "galleryImage", EmitDefaultValue = false)]
        public string GalleryImage { get; set; }
        /// <summary>
        /// Gets or Sets HelpText
        /// </summary>
        [DataMember(Name = "helpText", EmitDefaultValue = false)]
        public string HelpText { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Parameters
        /// </summary>
        [DataMember(Name = "parameters", EmitDefaultValue = false)]
        public Dictionary<string, string> Parameters { get; set; }
        /// <summary>
        /// Gets or Sets Visible
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
            return this.Equals(obj as CoreAction);
        }

        /// <summary>
        /// Returns true if CoreAction instances are equal
        /// </summary>
        /// <param name="other">Instance of CoreAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CoreAction? other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.ActionCommand == other.ActionCommand ||
                    this.ActionCommand != null &&
                    this.ActionCommand.Equals(other.ActionCommand, StringComparison.Ordinal)
                ) &&
                (
                    this.ActionType == other.ActionType ||
                    this.ActionType != null &&
                    this.ActionType.Equals(other.ActionType)
                ) &&
                (
                    this.AlwaysTextAndImage == other.AlwaysTextAndImage ||
                    this.AlwaysTextAndImage != null &&
                    this.AlwaysTextAndImage.Equals(other.AlwaysTextAndImage)
                ) &&
                (
                    this.BeginGroup == other.BeginGroup ||
                    this.BeginGroup != null &&
                    this.BeginGroup.Equals(other.BeginGroup)
                ) &&
                (
                    this.ChildActions == other.ChildActions ||
                    this.ChildActions != null &&
                    this.ChildActions.SequenceEqual(other.ChildActions)
                ) &&
                (
                    this.Dependencies == other.Dependencies ||
                    this.Dependencies != null &&
                    this.Dependencies.SequenceEqual(other.Dependencies)
                ) &&
                (
                    this.DisplayText == other.DisplayText ||
                    this.DisplayText != null &&
                    this.DisplayText.Equals(other.DisplayText, StringComparison.Ordinal)
                ) &&
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) &&
                (
                    this.GalleryImage == other.GalleryImage ||
                    this.GalleryImage != null &&
                    this.GalleryImage.Equals(other.GalleryImage, StringComparison.Ordinal)
                ) &&
                (
                    this.HelpText == other.HelpText ||
                    this.HelpText != null &&
                    this.HelpText.Equals(other.HelpText, StringComparison.Ordinal)
                ) &&
                (
                    this.LoginEnabledMode == other.LoginEnabledMode ||
                    this.LoginEnabledMode != null &&
                    this.LoginEnabledMode.Equals(other.LoginEnabledMode)
                ) &&
                (
                    this.LoginVisibilityMode == other.LoginVisibilityMode ||
                    this.LoginVisibilityMode != null &&
                    this.LoginVisibilityMode.Equals(other.LoginVisibilityMode)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name, StringComparison.Ordinal)
                ) &&
                (
                    this.Parameters == other.Parameters ||
                    this.Parameters != null &&
                    this.Parameters.SequenceEqual(other.Parameters)
                ) &&
                (
                    this.Visible == other.Visible ||
                    this.Visible != null &&
                    this.Visible.Equals(other.Visible)
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
                if (this.ActionCommand != null)
                    hash = hash * 59 + this.ActionCommand.GetHashCode();
                if (this.ActionType != null)
                    hash = hash * 59 + this.ActionType.GetHashCode();
                if (this.AlwaysTextAndImage != null)
                    hash = hash * 59 + this.AlwaysTextAndImage.GetHashCode();
                if (this.BeginGroup != null)
                    hash = hash * 59 + this.BeginGroup.GetHashCode();
                if (this.ChildActions != null)
                    hash = hash * 59 + this.ChildActions.GetHashCode();
                if (this.Dependencies != null)
                    hash = hash * 59 + this.Dependencies.GetHashCode();
                if (this.DisplayText != null)
                    hash = hash * 59 + this.DisplayText.GetHashCode();
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();
                if (this.GalleryImage != null)
                    hash = hash * 59 + this.GalleryImage.GetHashCode();
                if (this.HelpText != null)
                    hash = hash * 59 + this.HelpText.GetHashCode();
                if (this.LoginEnabledMode != null)
                    hash = hash * 59 + this.LoginEnabledMode.GetHashCode();
                if (this.LoginVisibilityMode != null)
                    hash = hash * 59 + this.LoginVisibilityMode.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Parameters != null)
                    hash = hash * 59 + this.Parameters.GetHashCode();
                if (this.Visible != null)
                    hash = hash * 59 + this.Visible.GetHashCode();
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
}
