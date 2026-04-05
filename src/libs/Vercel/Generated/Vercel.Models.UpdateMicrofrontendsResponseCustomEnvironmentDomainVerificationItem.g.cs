
#nullable enable

namespace Vercel
{
    /// <summary>
    /// A list of verification challenges, one of which must be completed to verify the domain for use on the project. After the challenge is complete `POST /projects/:idOrName/domains/:domain/verify` to verify the domain. Possible challenges: - If `verification.type = TXT` the `verification.domain` will be checked for a TXT record matching `verification.value`.
    /// </summary>
    public sealed partial class UpdateMicrofrontendsResponseCustomEnvironmentDomainVerificationItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Domain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMicrofrontendsResponseCustomEnvironmentDomainVerificationItem" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="domain"></param>
        /// <param name="value"></param>
        /// <param name="reason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateMicrofrontendsResponseCustomEnvironmentDomainVerificationItem(
            string type,
            string domain,
            string value,
            string reason)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Domain = domain ?? throw new global::System.ArgumentNullException(nameof(domain));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Reason = reason ?? throw new global::System.ArgumentNullException(nameof(reason));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMicrofrontendsResponseCustomEnvironmentDomainVerificationItem" /> class.
        /// </summary>
        public UpdateMicrofrontendsResponseCustomEnvironmentDomainVerificationItem()
        {
        }
    }
}