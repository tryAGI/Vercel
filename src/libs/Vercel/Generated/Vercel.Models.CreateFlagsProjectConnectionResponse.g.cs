
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateFlagsProjectConnectionResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consumerProjectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConsumerProjectId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consumerProjectName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConsumerProjectName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdBy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedBy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceProjectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceProjectId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceProjectName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceProjectName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFlagsProjectConnectionResponse" /> class.
        /// </summary>
        /// <param name="consumerProjectId"></param>
        /// <param name="consumerProjectName"></param>
        /// <param name="createdAt"></param>
        /// <param name="createdBy"></param>
        /// <param name="sourceProjectId"></param>
        /// <param name="sourceProjectName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateFlagsProjectConnectionResponse(
            string consumerProjectId,
            string consumerProjectName,
            double createdAt,
            string createdBy,
            string sourceProjectId,
            string sourceProjectName)
        {
            this.ConsumerProjectId = consumerProjectId ?? throw new global::System.ArgumentNullException(nameof(consumerProjectId));
            this.ConsumerProjectName = consumerProjectName ?? throw new global::System.ArgumentNullException(nameof(consumerProjectName));
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy ?? throw new global::System.ArgumentNullException(nameof(createdBy));
            this.SourceProjectId = sourceProjectId ?? throw new global::System.ArgumentNullException(nameof(sourceProjectId));
            this.SourceProjectName = sourceProjectName ?? throw new global::System.ArgumentNullException(nameof(sourceProjectName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFlagsProjectConnectionResponse" /> class.
        /// </summary>
        public CreateFlagsProjectConnectionResponse()
        {
        }

    }
}