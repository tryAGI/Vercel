
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VcrImageLayerVariant1
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.VcrImageLayerVariant1OperationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.VcrImageLayerVariant1Operation Operation { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sizeBytes")]
        public double? SizeBytes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.VcrImageLayerVariant1TypeJsonConverter))]
        public global::Vercel.VcrImageLayerVariant1Type Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseImage")]
        public string? BaseImage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collapsedDigests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> CollapsedDigests { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collapsedLayerCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CollapsedLayerCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VcrImageLayerVariant1" /> class.
        /// </summary>
        /// <param name="operation">
        /// Docker/OCI build instruction associated with an image layer.
        /// </param>
        /// <param name="collapsedDigests"></param>
        /// <param name="collapsedLayerCount"></param>
        /// <param name="createdBy"></param>
        /// <param name="digest"></param>
        /// <param name="sizeBytes"></param>
        /// <param name="type"></param>
        /// <param name="baseImage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VcrImageLayerVariant1(
            global::Vercel.VcrImageLayerVariant1Operation operation,
            global::System.Collections.Generic.IList<string> collapsedDigests,
            double collapsedLayerCount,
            string? createdBy,
            string? digest,
            double? sizeBytes,
            global::Vercel.VcrImageLayerVariant1Type type,
            string? baseImage)
        {
            this.CreatedBy = createdBy;
            this.Digest = digest;
            this.Operation = operation;
            this.SizeBytes = sizeBytes;
            this.Type = type;
            this.BaseImage = baseImage;
            this.CollapsedDigests = collapsedDigests ?? throw new global::System.ArgumentNullException(nameof(collapsedDigests));
            this.CollapsedLayerCount = collapsedLayerCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VcrImageLayerVariant1" /> class.
        /// </summary>
        public VcrImageLayerVariant1()
        {
        }

    }
}