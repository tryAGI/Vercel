
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetConfigurationResponseVariant1TransferRequestVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("approvedAt")]
        public double? ApprovedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("approvedBy")]
        public string? ApprovedBy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorizationId")]
        public string? AuthorizationId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discardedAt")]
        public double? DiscardedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discardedBy")]
        public string? DiscardedBy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiresAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ExpiresAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetConfigurationResponseVariant1TransferRequestVariant2KindJsonConverter))]
        public global::Vercel.GetConfigurationResponseVariant1TransferRequestVariant2Kind Kind { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requester")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetConfigurationResponseVariant1TransferRequestVariant2Requester Requester { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transferId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TransferId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConfigurationResponseVariant1TransferRequestVariant2" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="expiresAt"></param>
        /// <param name="requester"></param>
        /// <param name="requestId"></param>
        /// <param name="transferId"></param>
        /// <param name="approvedAt"></param>
        /// <param name="approvedBy"></param>
        /// <param name="authorizationId"></param>
        /// <param name="discardedAt"></param>
        /// <param name="discardedBy"></param>
        /// <param name="kind"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetConfigurationResponseVariant1TransferRequestVariant2(
            double createdAt,
            double expiresAt,
            global::Vercel.GetConfigurationResponseVariant1TransferRequestVariant2Requester requester,
            string requestId,
            string transferId,
            double? approvedAt,
            string? approvedBy,
            string? authorizationId,
            double? discardedAt,
            string? discardedBy,
            global::Vercel.GetConfigurationResponseVariant1TransferRequestVariant2Kind kind)
        {
            this.ApprovedAt = approvedAt;
            this.ApprovedBy = approvedBy;
            this.AuthorizationId = authorizationId;
            this.CreatedAt = createdAt;
            this.DiscardedAt = discardedAt;
            this.DiscardedBy = discardedBy;
            this.ExpiresAt = expiresAt;
            this.Kind = kind;
            this.Requester = requester ?? throw new global::System.ArgumentNullException(nameof(requester));
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.TransferId = transferId ?? throw new global::System.ArgumentNullException(nameof(transferId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConfigurationResponseVariant1TransferRequestVariant2" /> class.
        /// </summary>
        public GetConfigurationResponseVariant1TransferRequestVariant2()
        {
        }

    }
}