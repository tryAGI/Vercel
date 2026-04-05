
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddRouteRequestRouteRoute
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("src")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Src { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dest")]
        public string? Dest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public object? Headers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("caseSensitive")]
        public bool? CaseSensitive { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public int? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has")]
        public global::System.Collections.Generic.IList<global::Vercel.AddRouteRequestRouteRouteHa>? Has { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("missing")]
        public global::System.Collections.Generic.IList<global::Vercel.AddRouteRequestRouteRouteMissingItem>? Missing { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transforms")]
        public global::System.Collections.Generic.IList<global::Vercel.AddRouteRequestRouteRouteTransform>? Transforms { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("respectOriginCacheControl")]
        public bool? RespectOriginCacheControl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddRouteRequestRouteRoute" /> class.
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dest"></param>
        /// <param name="headers"></param>
        /// <param name="caseSensitive"></param>
        /// <param name="status"></param>
        /// <param name="has"></param>
        /// <param name="missing"></param>
        /// <param name="transforms"></param>
        /// <param name="respectOriginCacheControl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddRouteRequestRouteRoute(
            string src,
            string? dest,
            object? headers,
            bool? caseSensitive,
            int? status,
            global::System.Collections.Generic.IList<global::Vercel.AddRouteRequestRouteRouteHa>? has,
            global::System.Collections.Generic.IList<global::Vercel.AddRouteRequestRouteRouteMissingItem>? missing,
            global::System.Collections.Generic.IList<global::Vercel.AddRouteRequestRouteRouteTransform>? transforms,
            bool? respectOriginCacheControl)
        {
            this.Src = src ?? throw new global::System.ArgumentNullException(nameof(src));
            this.Dest = dest;
            this.Headers = headers;
            this.CaseSensitive = caseSensitive;
            this.Status = status;
            this.Has = has;
            this.Missing = missing;
            this.Transforms = transforms;
            this.RespectOriginCacheControl = respectOriginCacheControl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddRouteRequestRouteRoute" /> class.
        /// </summary>
        public AddRouteRequestRouteRoute()
        {
        }
    }
}