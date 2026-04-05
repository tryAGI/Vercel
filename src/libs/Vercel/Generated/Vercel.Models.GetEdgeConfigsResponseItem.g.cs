
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetEdgeConfigsResponseItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public double? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownerId")]
        public string? OwnerId { get; set; }

        /// <summary>
        /// Name for the Edge Config Names are not unique. Must start with an alphabetic character and can contain only alphanumeric characters and underscores).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public double? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("digest")]
        public string? Digest { get; set; }

        /// <summary>
        /// Keeps track of the current state of the Edge Config while it gets transferred.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer")]
        public global::Vercel.GetEdgeConfigsResponseItemTransfer? Transfer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        public object? Schema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purpose")]
        public global::Vercel.GetEdgeConfigsResponseItemPurpose? Purpose { get; set; }

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
        /// Initializes a new instance of the <see cref="GetEdgeConfigsResponseItem" /> class.
        /// </summary>
        /// <param name="sizeInBytes"></param>
        /// <param name="itemCount"></param>
        /// <param name="id"></param>
        /// <param name="createdAt"></param>
        /// <param name="ownerId"></param>
        /// <param name="slug">
        /// Name for the Edge Config Names are not unique. Must start with an alphabetic character and can contain only alphanumeric characters and underscores).
        /// </param>
        /// <param name="updatedAt"></param>
        /// <param name="digest"></param>
        /// <param name="transfer">
        /// Keeps track of the current state of the Edge Config while it gets transferred.
        /// </param>
        /// <param name="schema"></param>
        /// <param name="purpose"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetEdgeConfigsResponseItem(
            double sizeInBytes,
            double itemCount,
            string? id,
            double? createdAt,
            string? ownerId,
            string? slug,
            double? updatedAt,
            string? digest,
            global::Vercel.GetEdgeConfigsResponseItemTransfer? transfer,
            object? schema,
            global::Vercel.GetEdgeConfigsResponseItemPurpose? purpose)
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.OwnerId = ownerId;
            this.Slug = slug;
            this.UpdatedAt = updatedAt;
            this.Digest = digest;
            this.Transfer = transfer;
            this.Schema = schema;
            this.Purpose = purpose;
            this.SizeInBytes = sizeInBytes;
            this.ItemCount = itemCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetEdgeConfigsResponseItem" /> class.
        /// </summary>
        public GetEdgeConfigsResponseItem()
        {
        }
    }
}