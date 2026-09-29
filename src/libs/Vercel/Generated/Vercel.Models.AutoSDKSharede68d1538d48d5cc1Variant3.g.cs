
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharede68d1538d48d5cc1Variant3
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharede68d1538d48d5cc1Variant3Base Base { get; set; }

        /// <summary>
        /// Epoch ms when the rollout begins
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startTimestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double StartTimestamp { get; set; }

        /// <summary>
        /// The variant to roll away from
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rollFromVariantId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RollFromVariantId { get; set; }

        /// <summary>
        /// The variant to roll towards
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rollToVariantId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RollToVariantId { get; set; }

        /// <summary>
        /// This variant will be used when the base attribute does not exist
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultVariantId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DefaultVariantId { get; set; }

        /// <summary>
        /// Each slot defines a promille and how long it is served for. After all slots expire, finalPromille is served indefinitely (100% when omitted). The final percentage does not need its own slot.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slots")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharede68d1538d48d5cc1Variant3Slot> Slots { get; set; }

        /// <summary>
        /// Traffic for rollToVariant after all slots expire (0-100_000, where 1_000 = 1%). Defaults to 100_000 (100%). Set 50_000 to end at 50%.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finalPromille")]
        public double? FinalPromille { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharede68d1538d48d5cc1Variant3" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="base"></param>
        /// <param name="startTimestamp">
        /// Epoch ms when the rollout begins
        /// </param>
        /// <param name="rollFromVariantId">
        /// The variant to roll away from
        /// </param>
        /// <param name="rollToVariantId">
        /// The variant to roll towards
        /// </param>
        /// <param name="defaultVariantId">
        /// This variant will be used when the base attribute does not exist
        /// </param>
        /// <param name="slots">
        /// Each slot defines a promille and how long it is served for. After all slots expire, finalPromille is served indefinitely (100% when omitted). The final percentage does not need its own slot.
        /// </param>
        /// <param name="finalPromille">
        /// Traffic for rollToVariant after all slots expire (0-100_000, where 1_000 = 1%). Defaults to 100_000 (100%). Set 50_000 to end at 50%.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharede68d1538d48d5cc1Variant3(
            object type,
            global::Vercel.AutoSDKSharede68d1538d48d5cc1Variant3Base @base,
            double startTimestamp,
            string rollFromVariantId,
            string rollToVariantId,
            string defaultVariantId,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharede68d1538d48d5cc1Variant3Slot> slots,
            double? finalPromille)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Base = @base ?? throw new global::System.ArgumentNullException(nameof(@base));
            this.StartTimestamp = startTimestamp;
            this.RollFromVariantId = rollFromVariantId ?? throw new global::System.ArgumentNullException(nameof(rollFromVariantId));
            this.RollToVariantId = rollToVariantId ?? throw new global::System.ArgumentNullException(nameof(rollToVariantId));
            this.DefaultVariantId = defaultVariantId ?? throw new global::System.ArgumentNullException(nameof(defaultVariantId));
            this.Slots = slots ?? throw new global::System.ArgumentNullException(nameof(slots));
            this.FinalPromille = finalPromille;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharede68d1538d48d5cc1Variant3" /> class.
        /// </summary>
        public AutoSDKSharede68d1538d48d5cc1Variant3()
        {
        }

    }
}