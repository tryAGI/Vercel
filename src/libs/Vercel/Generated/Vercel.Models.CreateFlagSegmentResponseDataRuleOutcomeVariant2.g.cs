
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateFlagSegmentResponseDataRuleOutcomeVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateFlagSegmentResponseDataRuleOutcomeVariant2TypeJsonConverter))]
        public global::Vercel.CreateFlagSegmentResponseDataRuleOutcomeVariant2Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateFlagSegmentResponseDataRuleOutcomeVariant2Base Base { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateFlagSegmentResponseDataRuleOutcomeVariant2" /> class.
        /// </summary>
        /// <param name="base"></param>
        /// <param name="passPromille"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateFlagSegmentResponseDataRuleOutcomeVariant2(
            global::Vercel.CreateFlagSegmentResponseDataRuleOutcomeVariant2Base @base,
            double passPromille,
            global::Vercel.CreateFlagSegmentResponseDataRuleOutcomeVariant2Type type)
        {
            this.Type = type;
            this.Base = @base ?? throw new global::System.ArgumentNullException(nameof(@base));
            this.PassPromille = passPromille;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFlagSegmentResponseDataRuleOutcomeVariant2" /> class.
        /// </summary>
        public CreateFlagSegmentResponseDataRuleOutcomeVariant2()
        {
        }
    }
}