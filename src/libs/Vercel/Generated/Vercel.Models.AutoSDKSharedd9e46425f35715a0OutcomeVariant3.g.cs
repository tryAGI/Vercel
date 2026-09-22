
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedd9e46425f35715a0OutcomeVariant3
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedd9e46425f35715a0OutcomeVariant3Base Base { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultVariantId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DefaultVariantId { get; set; }

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
        public required global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedd9e46425f35715a0OutcomeVariant3Slot> Slots { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedd9e46425f35715a0OutcomeVariant3TypeJsonConverter))]
        public global::Vercel.AutoSDKSharedd9e46425f35715a0OutcomeVariant3Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedd9e46425f35715a0OutcomeVariant3" /> class.
        /// </summary>
        /// <param name="base"></param>
        /// <param name="defaultVariantId"></param>
        /// <param name="rollFromVariantId"></param>
        /// <param name="rollToVariantId"></param>
        /// <param name="slots"></param>
        /// <param name="startTimestamp"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedd9e46425f35715a0OutcomeVariant3(
            global::Vercel.AutoSDKSharedd9e46425f35715a0OutcomeVariant3Base @base,
            string defaultVariantId,
            string rollFromVariantId,
            string rollToVariantId,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedd9e46425f35715a0OutcomeVariant3Slot> slots,
            double startTimestamp,
            global::Vercel.AutoSDKSharedd9e46425f35715a0OutcomeVariant3Type type)
        {
            this.Base = @base ?? throw new global::System.ArgumentNullException(nameof(@base));
            this.DefaultVariantId = defaultVariantId ?? throw new global::System.ArgumentNullException(nameof(defaultVariantId));
            this.RollFromVariantId = rollFromVariantId ?? throw new global::System.ArgumentNullException(nameof(rollFromVariantId));
            this.RollToVariantId = rollToVariantId ?? throw new global::System.ArgumentNullException(nameof(rollToVariantId));
            this.Slots = slots ?? throw new global::System.ArgumentNullException(nameof(slots));
            this.StartTimestamp = startTimestamp;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedd9e46425f35715a0OutcomeVariant3" /> class.
        /// </summary>
        public AutoSDKSharedd9e46425f35715a0OutcomeVariant3()
        {
        }

    }
}