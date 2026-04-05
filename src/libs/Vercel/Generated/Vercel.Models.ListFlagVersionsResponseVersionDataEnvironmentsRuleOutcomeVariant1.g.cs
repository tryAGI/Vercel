
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListFlagVersionsResponseVersionDataEnvironmentsRuleOutcomeVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ListFlagVersionsResponseVersionDataEnvironmentsRuleOutcomeVariant1TypeJsonConverter))]
        public global::Vercel.ListFlagVersionsResponseVersionDataEnvironmentsRuleOutcomeVariant1Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variantId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VariantId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListFlagVersionsResponseVersionDataEnvironmentsRuleOutcomeVariant1" /> class.
        /// </summary>
        /// <param name="variantId"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListFlagVersionsResponseVersionDataEnvironmentsRuleOutcomeVariant1(
            string variantId,
            global::Vercel.ListFlagVersionsResponseVersionDataEnvironmentsRuleOutcomeVariant1Type type)
        {
            this.Type = type;
            this.VariantId = variantId ?? throw new global::System.ArgumentNullException(nameof(variantId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListFlagVersionsResponseVersionDataEnvironmentsRuleOutcomeVariant1" /> class.
        /// </summary>
        public ListFlagVersionsResponseVersionDataEnvironmentsRuleOutcomeVariant1()
        {
        }
    }
}