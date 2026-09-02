
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdatePrivateLinkEndpointRequest
    {
        /// <summary>
        /// A new name for the PrivateLink endpoint. When omitted, the current name is kept.<br/>
        /// Example: payments-db
        /// </summary>
        /// <example>payments-db</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// When `true`, resolves the endpoint service through its private DNS names, which are then returned in `privateDnsNames`. When `false`, clears them. When omitted, the current setting is kept. At least one of `name` or `enablePrivateDns` must be provided.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enablePrivateDns")]
        public bool? EnablePrivateDns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePrivateLinkEndpointRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// A new name for the PrivateLink endpoint. When omitted, the current name is kept.<br/>
        /// Example: payments-db
        /// </param>
        /// <param name="enablePrivateDns">
        /// When `true`, resolves the endpoint service through its private DNS names, which are then returned in `privateDnsNames`. When `false`, clears them. When omitted, the current setting is kept. At least one of `name` or `enablePrivateDns` must be provided.<br/>
        /// Example: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdatePrivateLinkEndpointRequest(
            string? name,
            bool? enablePrivateDns)
        {
            this.Name = name;
            this.EnablePrivateDns = enablePrivateDns;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePrivateLinkEndpointRequest" /> class.
        /// </summary>
        public UpdatePrivateLinkEndpointRequest()
        {
        }

    }
}