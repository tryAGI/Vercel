
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The Global Config.
    /// </summary>
    public sealed partial class GetEdgeConfigResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// The ID of the user who created the Global Config, optional because it is not always set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdBy")]
        public string? CreatedBy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deletedAt")]
        public double? DeletedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("digest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Digest { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownerId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnerId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purpose")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.GetEdgeConfigResponsePurposeVariant1, global::Vercel.GetEdgeConfigResponsePurposeVariant2>))]
        public global::Vercel.OneOf<global::Vercel.GetEdgeConfigResponsePurposeVariant1, global::Vercel.GetEdgeConfigResponsePurposeVariant2>? Purpose { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        public object? Schema { get; set; }

        /// <summary>
        /// Name for the Global Config Names are not unique. Must start with an alphabetic character and can contain only alphanumeric characters and underscores).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// Timestamp of when the Global Config was synced to DynamoDB initially. It is only set when syncing the entire Global Config, not when updating.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("syncedToDynamoAt")]
        public double? SyncedToDynamoAt { get; set; }

        /// <summary>
        /// Keeps track of the current state of the Global Config while it gets transferred.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer")]
        public global::Vercel.GetEdgeConfigResponseTransfer? Transfer { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UpdatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("itemCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ItemCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sizeInBytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SizeInBytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetEdgeConfigResponse" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="digest"></param>
        /// <param name="id"></param>
        /// <param name="ownerId"></param>
        /// <param name="slug">
        /// Name for the Global Config Names are not unique. Must start with an alphabetic character and can contain only alphanumeric characters and underscores).
        /// </param>
        /// <param name="updatedAt"></param>
        /// <param name="itemCount"></param>
        /// <param name="sizeInBytes"></param>
        /// <param name="createdBy">
        /// The ID of the user who created the Global Config, optional because it is not always set.
        /// </param>
        /// <param name="deletedAt"></param>
        /// <param name="purpose"></param>
        /// <param name="schema"></param>
        /// <param name="syncedToDynamoAt">
        /// Timestamp of when the Global Config was synced to DynamoDB initially. It is only set when syncing the entire Global Config, not when updating.
        /// </param>
        /// <param name="transfer">
        /// Keeps track of the current state of the Global Config while it gets transferred.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetEdgeConfigResponse(
            double createdAt,
            string digest,
            string id,
            string ownerId,
            string slug,
            double updatedAt,
            double itemCount,
            double sizeInBytes,
            string? createdBy,
            double? deletedAt,
            global::Vercel.OneOf<global::Vercel.GetEdgeConfigResponsePurposeVariant1, global::Vercel.GetEdgeConfigResponsePurposeVariant2>? purpose,
            object? schema,
            double? syncedToDynamoAt,
            global::Vercel.GetEdgeConfigResponseTransfer? transfer)
        {
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.DeletedAt = deletedAt;
            this.Digest = digest ?? throw new global::System.ArgumentNullException(nameof(digest));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OwnerId = ownerId ?? throw new global::System.ArgumentNullException(nameof(ownerId));
            this.Purpose = purpose;
            this.Schema = schema;
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.SyncedToDynamoAt = syncedToDynamoAt;
            this.Transfer = transfer;
            this.UpdatedAt = updatedAt;
            this.ItemCount = itemCount;
            this.SizeInBytes = sizeInBytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetEdgeConfigResponse" /> class.
        /// </summary>
        public GetEdgeConfigResponse()
        {
        }

    }
}