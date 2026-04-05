
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetMicrofrontendsInGroupResponseProjectProtectionBypassVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdBy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetMicrofrontendsInGroupResponseProjectProtectionBypassVariant2ScopeJsonConverter))]
        public global::Vercel.GetMicrofrontendsInGroupResponseProjectProtectionBypassVariant2Scope Scope { get; set; }

        /// <summary>
        /// When there was only one bypass, it was automatically set as an env var on deployments. With multiple bypasses, there is always one bypass that is selected as the default, and gets set as an env var on deployments. As this is a new field, undefined means that the bypass is the env var. If there are any automation bypasses, exactly one must be the env var.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isEnvVar")]
        public bool? IsEnvVar { get; set; }

        /// <summary>
        /// Optional note about the bypass to be displayed in the UI
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("note")]
        public string? Note { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMicrofrontendsInGroupResponseProjectProtectionBypassVariant2" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="createdBy"></param>
        /// <param name="scope"></param>
        /// <param name="isEnvVar">
        /// When there was only one bypass, it was automatically set as an env var on deployments. With multiple bypasses, there is always one bypass that is selected as the default, and gets set as an env var on deployments. As this is a new field, undefined means that the bypass is the env var. If there are any automation bypasses, exactly one must be the env var.
        /// </param>
        /// <param name="note">
        /// Optional note about the bypass to be displayed in the UI
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetMicrofrontendsInGroupResponseProjectProtectionBypassVariant2(
            double createdAt,
            string createdBy,
            global::Vercel.GetMicrofrontendsInGroupResponseProjectProtectionBypassVariant2Scope scope,
            bool? isEnvVar,
            string? note)
        {
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy ?? throw new global::System.ArgumentNullException(nameof(createdBy));
            this.Scope = scope;
            this.IsEnvVar = isEnvVar;
            this.Note = note;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMicrofrontendsInGroupResponseProjectProtectionBypassVariant2" /> class.
        /// </summary>
        public GetMicrofrontendsInGroupResponseProjectProtectionBypassVariant2()
        {
        }
    }
}