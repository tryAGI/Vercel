
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateRouteRequestCurrentRouteCondition
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        public string? Field { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        public string? Operator { get; set; }

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
        public bool? Missing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateRouteRequestCurrentRouteCondition" /> class.
        /// </summary>
        /// <param name="field"></param>
        /// <param name="operator"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="missing"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateRouteRequestCurrentRouteCondition(
            string? field,
            string? @operator,
            string? key,
            string? value,
            bool? missing)
        {
            this.Field = field;
            this.Operator = @operator;
            this.Key = key;
            this.Value = value;
            this.Missing = missing;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateRouteRequestCurrentRouteCondition" /> class.
        /// </summary>
        public GenerateRouteRequestCurrentRouteCondition()
        {
        }
    }
}