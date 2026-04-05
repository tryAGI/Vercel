
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchUrlProtectionBypassRequestVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("override")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.PatchUrlProtectionBypassRequestVariant3Override Override { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchUrlProtectionBypassRequestVariant3" /> class.
        /// </summary>
        /// <param name="override"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchUrlProtectionBypassRequestVariant3(
            global::Vercel.PatchUrlProtectionBypassRequestVariant3Override @override)
        {
            this.Override = @override ?? throw new global::System.ArgumentNullException(nameof(@override));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchUrlProtectionBypassRequestVariant3" /> class.
        /// </summary>
        public PatchUrlProtectionBypassRequestVariant3()
        {
        }
    }
}