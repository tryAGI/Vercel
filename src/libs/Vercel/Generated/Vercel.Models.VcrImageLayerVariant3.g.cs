
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VcrImageLayerVariant3
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.VcrImageLayerVariant3OperationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.VcrImageLayerVariant3Operation Operation { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sizeBytes")]
        public double? SizeBytes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.VcrImageLayerVariant3TypeJsonConverter))]
        public global::Vercel.VcrImageLayerVariant3Type Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("env")]
        public string? Env { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VcrImageLayerVariant3" /> class.
        /// </summary>
        /// <param name="operation">
        /// Docker/OCI build instruction associated with an image layer.
        /// </param>
        /// <param name="createdBy"></param>
        /// <param name="digest"></param>
        /// <param name="sizeBytes"></param>
        /// <param name="type"></param>
        /// <param name="env"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VcrImageLayerVariant3(
            global::Vercel.VcrImageLayerVariant3Operation operation,
            string? createdBy,
            string? digest,
            double? sizeBytes,
            global::Vercel.VcrImageLayerVariant3Type type,
            string? env)
        {
            this.CreatedBy = createdBy;
            this.Digest = digest;
            this.Operation = operation;
            this.SizeBytes = sizeBytes;
            this.Type = type;
            this.Env = env;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VcrImageLayerVariant3" /> class.
        /// </summary>
        public VcrImageLayerVariant3()
        {
        }

    }
}