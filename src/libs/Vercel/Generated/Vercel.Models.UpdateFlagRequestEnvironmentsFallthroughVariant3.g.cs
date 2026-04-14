
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateFlagRequestEnvironmentsFallthroughVariant3
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
        public required global::Vercel.UpdateFlagRequestEnvironmentsFallthroughVariant3Base Base { get; set; }

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
        /// Each slot defines a promille and how long it is served for. After all slots expire, 100% is served indefinitely. The final implicit 100% slot does not need to be listed. Example: [[5_000, 21_600_000], [10_000, 28_800_000]] means 5‰ for 6h, then 10‰ for 8h, then 100% indefinitely.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slots")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.UpdateFlagRequestEnvironmentsFallthroughVariant3Slot> Slots { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFlagRequestEnvironmentsFallthroughVariant3" /> class.
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
        /// Each slot defines a promille and how long it is served for. After all slots expire, 100% is served indefinitely. The final implicit 100% slot does not need to be listed. Example: [[5_000, 21_600_000], [10_000, 28_800_000]] means 5‰ for 6h, then 10‰ for 8h, then 100% indefinitely.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateFlagRequestEnvironmentsFallthroughVariant3(
            object type,
            global::Vercel.UpdateFlagRequestEnvironmentsFallthroughVariant3Base @base,
            double startTimestamp,
            string rollFromVariantId,
            string rollToVariantId,
            string defaultVariantId,
            global::System.Collections.Generic.IList<global::Vercel.UpdateFlagRequestEnvironmentsFallthroughVariant3Slot> slots)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Base = @base ?? throw new global::System.ArgumentNullException(nameof(@base));
            this.StartTimestamp = startTimestamp;
            this.RollFromVariantId = rollFromVariantId ?? throw new global::System.ArgumentNullException(nameof(rollFromVariantId));
            this.RollToVariantId = rollToVariantId ?? throw new global::System.ArgumentNullException(nameof(rollToVariantId));
            this.DefaultVariantId = defaultVariantId ?? throw new global::System.ArgumentNullException(nameof(defaultVariantId));
            this.Slots = slots ?? throw new global::System.ArgumentNullException(nameof(slots));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFlagRequestEnvironmentsFallthroughVariant3" /> class.
        /// </summary>
        public UpdateFlagRequestEnvironmentsFallthroughVariant3()
        {
        }
    }
}