
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateProjectRequestTrustedIpsAddresse
    {
        /// <summary>
        /// The IP addresses that are allowlisted. Supports IPv4 addresses and CIDR notations. IPv6 is not supported
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// An optional note explaining what the IP address or subnet is used for
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("note")]
        public string? Note { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequestTrustedIpsAddresse" /> class.
        /// </summary>
        /// <param name="value">
        /// The IP addresses that are allowlisted. Supports IPv4 addresses and CIDR notations. IPv6 is not supported
        /// </param>
        /// <param name="note">
        /// An optional note explaining what the IP address or subnet is used for
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateProjectRequestTrustedIpsAddresse(
            string value,
            string? note)
        {
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Note = note;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequestTrustedIpsAddresse" /> class.
        /// </summary>
        public UpdateProjectRequestTrustedIpsAddresse()
        {
        }
    }
}