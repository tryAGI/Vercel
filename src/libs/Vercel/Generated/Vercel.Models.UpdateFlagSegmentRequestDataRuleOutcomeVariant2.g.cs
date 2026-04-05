
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateFlagSegmentRequestDataRuleOutcomeVariant2
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
        public required global::Vercel.UpdateFlagSegmentRequestDataRuleOutcomeVariant2Base Base { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passPromille")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PassPromille { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFlagSegmentRequestDataRuleOutcomeVariant2" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="base"></param>
        /// <param name="passPromille"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateFlagSegmentRequestDataRuleOutcomeVariant2(
            object type,
            global::Vercel.UpdateFlagSegmentRequestDataRuleOutcomeVariant2Base @base,
            double passPromille)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Base = @base ?? throw new global::System.ArgumentNullException(nameof(@base));
            this.PassPromille = passPromille;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFlagSegmentRequestDataRuleOutcomeVariant2" /> class.
        /// </summary>
        public UpdateFlagSegmentRequestDataRuleOutcomeVariant2()
        {
        }
    }
}