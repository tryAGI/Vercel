
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateRouteRequestCurrentRoutePathCondition
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("syntax")]
        public string? Syntax { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateRouteRequestCurrentRoutePathCondition" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="syntax"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateRouteRequestCurrentRoutePathCondition(
            string? value,
            string? syntax)
        {
            this.Value = value;
            this.Syntax = syntax;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateRouteRequestCurrentRoutePathCondition" /> class.
        /// </summary>
        public GenerateRouteRequestCurrentRoutePathCondition()
        {
        }
    }
}