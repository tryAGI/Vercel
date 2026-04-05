
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    /// update
    /// </summary>
    public sealed partial class PatchDomainRequestVariant1
    {
        /// <summary>
        /// Example: update
        /// </summary>
        /// <example>update</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("op")]
        public string? Op { get; set; }

        /// <summary>
        /// This field is deprecated. Please use PATCH /v1/registrar/domains/{domainName}/auto-renew instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("renew")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? Renew { get; set; }

        /// <summary>
        /// This field is deprecated. Please use PATCH /v1/registrar/domains/{domainName}/nameservers instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customNameservers")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<string>? CustomNameservers { get; set; }

        /// <summary>
        /// Specifies whether this is a DNS zone that intends to use Vercel's nameservers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("zone")]
        public bool? Zone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchDomainRequestVariant1" /> class.
        /// </summary>
        /// <param name="op">
        /// Example: update
        /// </param>
        /// <param name="zone">
        /// Specifies whether this is a DNS zone that intends to use Vercel's nameservers.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchDomainRequestVariant1(
            string? op,
            bool? zone)
        {
            this.Op = op;
            this.Zone = zone;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchDomainRequestVariant1" /> class.
        /// </summary>
        public PatchDomainRequestVariant1()
        {
        }
    }
}