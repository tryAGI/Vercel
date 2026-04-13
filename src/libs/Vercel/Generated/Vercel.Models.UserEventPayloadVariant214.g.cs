
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant214
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trustedIps")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant214TrustedIpsJsonConverter))]
        public global::Vercel.UserEventPayloadVariant214TrustedIps? TrustedIps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oldTrustedIps")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant214OldTrustedIpsJsonConverter))]
        public global::Vercel.UserEventPayloadVariant214OldTrustedIps? OldTrustedIps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("addedAddresses")]
        public global::System.Collections.Generic.IList<string>? AddedAddresses { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removedAddresses")]
        public global::System.Collections.Generic.IList<string>? RemovedAddresses { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant214" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="projectName"></param>
        /// <param name="trustedIps"></param>
        /// <param name="oldTrustedIps"></param>
        /// <param name="addedAddresses"></param>
        /// <param name="removedAddresses"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant214(
            string projectId,
            string projectName,
            global::Vercel.UserEventPayloadVariant214TrustedIps? trustedIps,
            global::Vercel.UserEventPayloadVariant214OldTrustedIps? oldTrustedIps,
            global::System.Collections.Generic.IList<string>? addedAddresses,
            global::System.Collections.Generic.IList<string>? removedAddresses)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.ProjectName = projectName ?? throw new global::System.ArgumentNullException(nameof(projectName));
            this.TrustedIps = trustedIps;
            this.OldTrustedIps = oldTrustedIps;
            this.AddedAddresses = addedAddresses;
            this.RemovedAddresses = removedAddresses;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant214" /> class.
        /// </summary>
        public UserEventPayloadVariant214()
        {
        }
    }
}