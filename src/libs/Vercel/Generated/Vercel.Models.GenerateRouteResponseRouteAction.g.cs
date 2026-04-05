
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateRouteResponseRouteAction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GenerateRouteResponseRouteActionTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GenerateRouteResponseRouteActionType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GenerateRouteResponseRouteActionSubTypeJsonConverter))]
        public global::Vercel.GenerateRouteResponseRouteActionSubType? SubType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dest")]
        public string? Dest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public double? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.IList<global::Vercel.GenerateRouteResponseRouteActionHeader>? Headers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateRouteResponseRouteAction" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="subType"></param>
        /// <param name="dest"></param>
        /// <param name="status"></param>
        /// <param name="headers"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateRouteResponseRouteAction(
            global::Vercel.GenerateRouteResponseRouteActionType type,
            global::Vercel.GenerateRouteResponseRouteActionSubType? subType,
            string? dest,
            double? status,
            global::System.Collections.Generic.IList<global::Vercel.GenerateRouteResponseRouteActionHeader>? headers)
        {
            this.Type = type;
            this.SubType = subType;
            this.Dest = dest;
            this.Status = status;
            this.Headers = headers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateRouteResponseRouteAction" /> class.
        /// </summary>
        public GenerateRouteResponseRouteAction()
        {
        }
    }
}