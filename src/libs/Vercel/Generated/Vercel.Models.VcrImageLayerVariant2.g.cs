
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VcrImageLayerVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdBy")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("digest")]
        public string? Digest { get; set; }

        /// <summary>
        /// Docker/OCI build instruction associated with an image layer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.VcrImageLayerVariant2OperationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.VcrImageLayerVariant2Operation Operation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sizeBytes")]
        public double? SizeBytes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.VcrImageLayerVariant2TypeJsonConverter))]
        public global::Vercel.VcrImageLayerVariant2Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("command")]
        public string? Command { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VcrImageLayerVariant2" /> class.
        /// </summary>
        /// <param name="operation">
        /// Docker/OCI build instruction associated with an image layer.
        /// </param>
        /// <param name="createdBy"></param>
        /// <param name="digest"></param>
        /// <param name="sizeBytes"></param>
        /// <param name="type"></param>
        /// <param name="command"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VcrImageLayerVariant2(
            global::Vercel.VcrImageLayerVariant2Operation operation,
            string? createdBy,
            string? digest,
            double? sizeBytes,
            global::Vercel.VcrImageLayerVariant2Type type,
            string? command)
        {
            this.CreatedBy = createdBy;
            this.Digest = digest;
            this.Operation = operation;
            this.SizeBytes = sizeBytes;
            this.Type = type;
            this.Command = command;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VcrImageLayerVariant2" /> class.
        /// </summary>
        public VcrImageLayerVariant2()
        {
        }

    }
}