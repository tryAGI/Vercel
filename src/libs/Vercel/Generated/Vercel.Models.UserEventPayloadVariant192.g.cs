
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
        [global::System.Text.Json.Serialization.JsonPropertyName("previousProjectName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PreviousProjectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("newProjectName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NewProjectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("originAccountName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OriginAccountName { get; set; }

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
        /// <param name="previousProjectName"></param>
        /// <param name="newProjectName"></param>
        /// <param name="originAccountName"></param>
        /// <param name="transferId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant192(
            string previousProjectName,
            string newProjectName,
            string originAccountName,
            string? transferId)
        {
            this.PreviousProjectName = previousProjectName ?? throw new global::System.ArgumentNullException(nameof(previousProjectName));
            this.NewProjectName = newProjectName ?? throw new global::System.ArgumentNullException(nameof(newProjectName));
            this.OriginAccountName = originAccountName ?? throw new global::System.ArgumentNullException(nameof(originAccountName));
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