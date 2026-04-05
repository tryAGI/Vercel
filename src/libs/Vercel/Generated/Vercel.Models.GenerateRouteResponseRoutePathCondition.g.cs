
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateRouteResponseRoutePathCondition
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("syntax")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GenerateRouteResponseRoutePathConditionSyntaxJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GenerateRouteResponseRoutePathConditionSyntax Syntax { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateRouteResponseRoutePathCondition" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="syntax"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateRouteResponseRoutePathCondition(
            string value,
            global::Vercel.GenerateRouteResponseRoutePathConditionSyntax syntax)
        {
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Syntax = syntax;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateRouteResponseRoutePathCondition" /> class.
        /// </summary>
        public GenerateRouteResponseRoutePathCondition()
        {
        }
    }
}