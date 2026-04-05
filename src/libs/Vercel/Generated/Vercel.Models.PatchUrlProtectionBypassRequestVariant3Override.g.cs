
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchUrlProtectionBypassRequestVariant3Override
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.PatchUrlProtectionBypassRequestVariant3OverrideScopeJsonConverter))]
        public global::Vercel.PatchUrlProtectionBypassRequestVariant3OverrideScope Scope { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.PatchUrlProtectionBypassRequestVariant3OverrideActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.PatchUrlProtectionBypassRequestVariant3OverrideAction Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchUrlProtectionBypassRequestVariant3Override" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="scope"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchUrlProtectionBypassRequestVariant3Override(
            global::Vercel.PatchUrlProtectionBypassRequestVariant3OverrideAction action,
            global::Vercel.PatchUrlProtectionBypassRequestVariant3OverrideScope scope)
        {
            this.Scope = scope;
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchUrlProtectionBypassRequestVariant3Override" /> class.
        /// </summary>
        public PatchUrlProtectionBypassRequestVariant3Override()
        {
        }
    }
}