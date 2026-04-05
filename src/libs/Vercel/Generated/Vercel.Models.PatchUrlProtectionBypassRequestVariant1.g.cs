
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchUrlProtectionBypassRequestVariant1
    {
        /// <summary>
        /// Optional time the shareable link is valid for in seconds. If not provided, the shareable link will never expire.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl")]
        public double? Ttl { get; set; }

        /// <summary>
        /// Optional instructions for revoking and regenerating a shareable link
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revoke")]
        public global::Vercel.PatchUrlProtectionBypassRequestVariant1Revoke? Revoke { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchUrlProtectionBypassRequestVariant1" /> class.
        /// </summary>
        /// <param name="ttl">
        /// Optional time the shareable link is valid for in seconds. If not provided, the shareable link will never expire.
        /// </param>
        /// <param name="revoke">
        /// Optional instructions for revoking and regenerating a shareable link
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchUrlProtectionBypassRequestVariant1(
            double? ttl,
            global::Vercel.PatchUrlProtectionBypassRequestVariant1Revoke? revoke)
        {
            this.Ttl = ttl;
            this.Revoke = revoke;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchUrlProtectionBypassRequestVariant1" /> class.
        /// </summary>
        public PatchUrlProtectionBypassRequestVariant1()
        {
        }
    }
}