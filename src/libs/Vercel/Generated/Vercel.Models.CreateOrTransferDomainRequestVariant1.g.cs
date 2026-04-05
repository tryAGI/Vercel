
#nullable enable

namespace Vercel
{
    /// <summary>
    /// add
    /// </summary>
    public sealed partial class CreateOrTransferDomainRequestVariant1
    {
        /// <summary>
        /// The domain name you want to add.<br/>
        /// Example: example.com
        /// </summary>
        /// <example>example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Whether the domain has the Vercel Edge Network enabled or not.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cdnEnabled")]
        public bool? CdnEnabled { get; set; }

        /// <summary>
        /// Whether to create a DNS zone on Vercel. Set `true` if using Vercel nameservers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("zone")]
        public bool? Zone { get; set; }

        /// <summary>
        /// The domain operation to perform.<br/>
        /// Example: add
        /// </summary>
        /// <example>add</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        public string? Method { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrTransferDomainRequestVariant1" /> class.
        /// </summary>
        /// <param name="name">
        /// The domain name you want to add.<br/>
        /// Example: example.com
        /// </param>
        /// <param name="cdnEnabled">
        /// Whether the domain has the Vercel Edge Network enabled or not.<br/>
        /// Example: true
        /// </param>
        /// <param name="zone">
        /// Whether to create a DNS zone on Vercel. Set `true` if using Vercel nameservers.
        /// </param>
        /// <param name="method">
        /// The domain operation to perform.<br/>
        /// Example: add
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateOrTransferDomainRequestVariant1(
            string name,
            bool? cdnEnabled,
            bool? zone,
            string? method)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CdnEnabled = cdnEnabled;
            this.Zone = zone;
            this.Method = method;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrTransferDomainRequestVariant1" /> class.
        /// </summary>
        public CreateOrTransferDomainRequestVariant1()
        {
        }
    }
}