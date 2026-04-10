
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant192
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
        [global::System.Text.Json.Serialization.JsonPropertyName("originAccountName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OriginAccountName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destinationAccountName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DestinationAccountName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destinationAccountId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DestinationAccountId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transferId")]
        public string? TransferId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant192" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="projectName"></param>
        /// <param name="originAccountName"></param>
        /// <param name="destinationAccountName"></param>
        /// <param name="destinationAccountId"></param>
        /// <param name="transferId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant192(
            string projectId,
            string projectName,
            string originAccountName,
            string destinationAccountName,
            string destinationAccountId,
            string? transferId)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.ProjectName = projectName ?? throw new global::System.ArgumentNullException(nameof(projectName));
            this.OriginAccountName = originAccountName ?? throw new global::System.ArgumentNullException(nameof(originAccountName));
            this.DestinationAccountName = destinationAccountName ?? throw new global::System.ArgumentNullException(nameof(destinationAccountName));
            this.DestinationAccountId = destinationAccountId ?? throw new global::System.ArgumentNullException(nameof(destinationAccountId));
            this.TransferId = transferId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant192" /> class.
        /// </summary>
        public UserEventPayloadVariant192()
        {
        }
    }
}