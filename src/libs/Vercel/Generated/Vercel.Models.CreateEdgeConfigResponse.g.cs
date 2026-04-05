
#nullable enable

namespace Vercel
{
    /// <summary>
    /// An Edge Config
    /// </summary>
    public sealed partial class CreateEdgeConfigResponse
    {
        /// <summary>
        /// Keeps track of the current state of the Edge Config while it gets transferred.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer")]
        public global::Vercel.CreateEdgeConfigResponseTransfer? Transfer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// The ID of the user who created the Edge Config, optional because it is not always set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdBy")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownerId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnerId { get; set; }

        /// <summary>
        /// Name for the Edge Config Names are not unique. Must start with an alphabetic character and can contain only alphanumeric characters and underscores).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("digest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Digest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purpose")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.CreateEdgeConfigResponsePurposeVariant1, global::Vercel.CreateEdgeConfigResponsePurposeVariant2>))]
        public global::Vercel.OneOf<global::Vercel.CreateEdgeConfigResponsePurposeVariant1, global::Vercel.CreateEdgeConfigResponsePurposeVariant2>? Purpose { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deletedAt")]
        public double? DeletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        public object? Schema { get; set; }

        /// <summary>
        /// Timestamp of when the Edge Config was synced to DynamoDB initially. It is only set when syncing the entire Edge Config, not when updating.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("syncedToDynamoAt")]
        public double? SyncedToDynamoAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sizeInBytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SizeInBytes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("itemCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ItemCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEdgeConfigResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="createdAt"></param>
        /// <param name="ownerId"></param>
        /// <param name="slug">
        /// Name for the Edge Config Names are not unique. Must start with an alphabetic character and can contain only alphanumeric characters and underscores).
        /// </param>
        /// <param name="updatedAt"></param>
        /// <param name="digest"></param>
        /// <param name="sizeInBytes"></param>
        /// <param name="itemCount"></param>
        /// <param name="transfer">
        /// Keeps track of the current state of the Edge Config while it gets transferred.
        /// </param>
        /// <param name="createdBy">
        /// The ID of the user who created the Edge Config, optional because it is not always set.
        /// </param>
        /// <param name="purpose"></param>
        /// <param name="deletedAt"></param>
        /// <param name="schema"></param>
        /// <param name="syncedToDynamoAt">
        /// Timestamp of when the Edge Config was synced to DynamoDB initially. It is only set when syncing the entire Edge Config, not when updating.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEdgeConfigResponse(
            string id,
            double createdAt,
            string ownerId,
            string slug,
            double updatedAt,
            string digest,
            double sizeInBytes,
            double itemCount,
            global::Vercel.CreateEdgeConfigResponseTransfer? transfer,
            string? createdBy,
            global::Vercel.OneOf<global::Vercel.CreateEdgeConfigResponsePurposeVariant1, global::Vercel.CreateEdgeConfigResponsePurposeVariant2>? purpose,
            double? deletedAt,
            object? schema,
            double? syncedToDynamoAt)
        {
            this.Transfer = transfer;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.OwnerId = ownerId ?? throw new global::System.ArgumentNullException(nameof(ownerId));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.UpdatedAt = updatedAt;
            this.Digest = digest ?? throw new global::System.ArgumentNullException(nameof(digest));
            this.Purpose = purpose;
            this.DeletedAt = deletedAt;
            this.Schema = schema;
            this.SyncedToDynamoAt = syncedToDynamoAt;
            this.SizeInBytes = sizeInBytes;
            this.ItemCount = itemCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEdgeConfigResponse" /> class.
        /// </summary>
        public CreateEdgeConfigResponse()
        {
        }
    }
}