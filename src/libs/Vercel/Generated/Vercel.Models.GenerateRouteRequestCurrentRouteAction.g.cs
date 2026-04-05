
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateRouteRequestCurrentRouteAction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subType")]
        public string? SubType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dest")]
        public string? Dest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public int? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.IList<global::Vercel.GenerateRouteRequestCurrentRouteActionHeader>? Headers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateRouteRequestCurrentRouteAction" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="subType"></param>
        /// <param name="dest"></param>
        /// <param name="status"></param>
        /// <param name="headers"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateRouteRequestCurrentRouteAction(
            string? type,
            string? subType,
            string? dest,
            int? status,
            global::System.Collections.Generic.IList<global::Vercel.GenerateRouteRequestCurrentRouteActionHeader>? headers)
        {
            this.Type = type;
            this.SubType = subType;
            this.Dest = dest;
            this.Status = status;
            this.Headers = headers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateRouteRequestCurrentRouteAction" /> class.
        /// </summary>
        public GenerateRouteRequestCurrentRouteAction()
        {
        }
    }
}