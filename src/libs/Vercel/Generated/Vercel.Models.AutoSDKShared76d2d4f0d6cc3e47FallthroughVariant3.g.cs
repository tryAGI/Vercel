
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared76d2d4f0d6cc3e47FallthroughVariant3
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared76d2d4f0d6cc3e47FallthroughVariant3Base Base { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultVariantId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DefaultVariantId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finalPromille")]
        public double? FinalPromille { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rollFromVariantId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RollFromVariantId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rollToVariantId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RollToVariantId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slots")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared76d2d4f0d6cc3e47FallthroughVariant3Slot> Slots { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startTimestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double StartTimestamp { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared76d2d4f0d6cc3e47FallthroughVariant3TypeJsonConverter))]
        public global::Vercel.AutoSDKShared76d2d4f0d6cc3e47FallthroughVariant3Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared76d2d4f0d6cc3e47FallthroughVariant3" /> class.
        /// </summary>
        /// <param name="base"></param>
        /// <param name="defaultVariantId"></param>
        /// <param name="rollFromVariantId"></param>
        /// <param name="rollToVariantId"></param>
        /// <param name="slots"></param>
        /// <param name="startTimestamp"></param>
        /// <param name="finalPromille"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared76d2d4f0d6cc3e47FallthroughVariant3(
            global::Vercel.AutoSDKShared76d2d4f0d6cc3e47FallthroughVariant3Base @base,
            string defaultVariantId,
            string rollFromVariantId,
            string rollToVariantId,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared76d2d4f0d6cc3e47FallthroughVariant3Slot> slots,
            double startTimestamp,
            double? finalPromille,
            global::Vercel.AutoSDKShared76d2d4f0d6cc3e47FallthroughVariant3Type type)
        {
            this.Base = @base ?? throw new global::System.ArgumentNullException(nameof(@base));
            this.DefaultVariantId = defaultVariantId ?? throw new global::System.ArgumentNullException(nameof(defaultVariantId));
            this.FinalPromille = finalPromille;
            this.RollFromVariantId = rollFromVariantId ?? throw new global::System.ArgumentNullException(nameof(rollFromVariantId));
            this.RollToVariantId = rollToVariantId ?? throw new global::System.ArgumentNullException(nameof(rollToVariantId));
            this.Slots = slots ?? throw new global::System.ArgumentNullException(nameof(slots));
            this.StartTimestamp = startTimestamp;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared76d2d4f0d6cc3e47FallthroughVariant3" /> class.
        /// </summary>
        public AutoSDKShared76d2d4f0d6cc3e47FallthroughVariant3()
        {
        }

    }
}