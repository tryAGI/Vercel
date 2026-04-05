
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateRouteResponseRouteCondition
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GenerateRouteResponseRouteConditionFieldJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GenerateRouteResponseRouteConditionField Field { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GenerateRouteResponseRouteConditionOperatorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GenerateRouteResponseRouteConditionOperator Operator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("missing")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Missing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateRouteResponseRouteCondition" /> class.
        /// </summary>
        /// <param name="field"></param>
        /// <param name="operator"></param>
        /// <param name="missing"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateRouteResponseRouteCondition(
            global::Vercel.GenerateRouteResponseRouteConditionField field,
            global::Vercel.GenerateRouteResponseRouteConditionOperator @operator,
            bool missing,
            string? key,
            string? value)
        {
            this.Field = field;
            this.Operator = @operator;
            this.Key = key;
            this.Value = value;
            this.Missing = missing;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateRouteResponseRouteCondition" /> class.
        /// </summary>
        public GenerateRouteResponseRouteCondition()
        {
        }
    }
}