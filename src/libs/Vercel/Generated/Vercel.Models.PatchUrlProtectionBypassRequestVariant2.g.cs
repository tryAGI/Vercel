
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchUrlProtectionBypassRequestVariant2
    {
        /// <summary>
        /// Instructions for creating a user scoped protection bypass
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.PatchUrlProtectionBypassRequestVariant2Scope Scope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchUrlProtectionBypassRequestVariant2" /> class.
        /// </summary>
        /// <param name="scope">
        /// Instructions for creating a user scoped protection bypass
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchUrlProtectionBypassRequestVariant2(
            global::Vercel.PatchUrlProtectionBypassRequestVariant2Scope scope)
        {
            this.Scope = scope ?? throw new global::System.ArgumentNullException(nameof(scope));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchUrlProtectionBypassRequestVariant2" /> class.
        /// </summary>
        public PatchUrlProtectionBypassRequestVariant2()
        {
        }
    }
}