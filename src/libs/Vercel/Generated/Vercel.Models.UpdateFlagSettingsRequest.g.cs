
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateFlagSettingsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entities")]
        public global::System.Collections.Generic.IList<global::Vercel.UpdateFlagSettingsRequestEntitie>? Entities { get; set; }

        /// <summary>
        /// The environments to sync
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        public global::System.Collections.Generic.IList<string>? Environments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFlagSettingsRequest" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="entities"></param>
        /// <param name="environments">
        /// The environments to sync
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateFlagSettingsRequest(
            bool? enabled,
            global::System.Collections.Generic.IList<global::Vercel.UpdateFlagSettingsRequestEntitie>? entities,
            global::System.Collections.Generic.IList<string>? environments)
        {
            this.Enabled = enabled;
            this.Entities = entities;
            this.Environments = environments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFlagSettingsRequest" /> class.
        /// </summary>
        public UpdateFlagSettingsRequest()
        {
        }
    }
}