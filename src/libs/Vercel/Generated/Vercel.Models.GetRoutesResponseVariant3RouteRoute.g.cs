
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The route definition from @vercel/routing-utils.
    /// </summary>
    public sealed partial class GetRoutesResponseVariant3RouteRoute
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("caseSensitive")]
        public bool? CaseSensitive { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("check")]
        public bool? Check { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("continue")]
        public bool? Continue { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dest")]
        public string? Dest { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destination")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.GetRoutesResponseVariant3RouteRouteDestination>))]
        public global::Vercel.OneOf<string, global::Vercel.GetRoutesResponseVariant3RouteRouteDestination>? Destination { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("env")]
        public global::System.Collections.Generic.IList<string>? Env { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has")]
        public global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.GetRoutesResponseVariant3RouteRouteHaVariant1, global::Vercel.GetRoutesResponseVariant3RouteRouteHaVariant2>>? Has { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("important")]
        public bool? Important { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locale")]
        public global::Vercel.GetRoutesResponseVariant3RouteRouteLocale? Locale { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("methods")]
        public global::System.Collections.Generic.IList<string>? Methods { get; set; }

        /// <summary>
        /// A middleware index in the `middleware` key under the build result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("middleware")]
        public double? Middleware { get; set; }

        /// <summary>
        /// A middleware key within the `output` key under the build result. Overrides a `middleware` definition.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("middlewarePath")]
        public string? MiddlewarePath { get; set; }

        /// <summary>
        /// The original middleware matchers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("middlewareRawSrc")]
        public global::System.Collections.Generic.IList<string>? MiddlewareRawSrc { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("missing")]
        public global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.GetRoutesResponseVariant3RouteRouteMissingItemVariant1, global::Vercel.GetRoutesResponseVariant3RouteRouteMissingItemVariant2>>? Missing { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mitigate")]
        public global::Vercel.GetRoutesResponseVariant3RouteRouteMitigate? Mitigate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("override")]
        public bool? Override { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("respectOriginCacheControl")]
        public bool? RespectOriginCacheControl { get; set; }

        /// <summary>
        /// Aliases for `src`, `dest`, and `status`. These provide consistency with the `rewrites`, `redirects`, and `headers` fields which use `source`, `destination`, and `statusCode`. During normalization, the string forms are converted to their canonical forms (`src`, `dest`, `status`) and stripped from the route object. `destination` may also be a service-targeted object, in which case routing is delegated into the named service's internal route table and the object is preserved as-is (not folded into `dest`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("src")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Src { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public double? Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statusCode")]
        public double? StatusCode { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transforms")]
        public global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.GetRoutesResponseVariant3RouteRouteTransformVariant1, global::Vercel.GetRoutesResponseVariant3RouteRouteTransformVariant2>>? Transforms { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRoutesResponseVariant3RouteRoute" /> class.
        /// </summary>
        /// <param name="src"></param>
        /// <param name="caseSensitive"></param>
        /// <param name="check"></param>
        /// <param name="continue"></param>
        /// <param name="dest"></param>
        /// <param name="destination"></param>
        /// <param name="env"></param>
        /// <param name="has"></param>
        /// <param name="headers"></param>
        /// <param name="important"></param>
        /// <param name="locale"></param>
        /// <param name="methods"></param>
        /// <param name="middleware">
        /// A middleware index in the `middleware` key under the build result
        /// </param>
        /// <param name="middlewarePath">
        /// A middleware key within the `output` key under the build result. Overrides a `middleware` definition.
        /// </param>
        /// <param name="middlewareRawSrc">
        /// The original middleware matchers.
        /// </param>
        /// <param name="missing"></param>
        /// <param name="mitigate"></param>
        /// <param name="override"></param>
        /// <param name="respectOriginCacheControl"></param>
        /// <param name="source">
        /// Aliases for `src`, `dest`, and `status`. These provide consistency with the `rewrites`, `redirects`, and `headers` fields which use `source`, `destination`, and `statusCode`. During normalization, the string forms are converted to their canonical forms (`src`, `dest`, `status`) and stripped from the route object. `destination` may also be a service-targeted object, in which case routing is delegated into the named service's internal route table and the object is preserved as-is (not folded into `dest`).
        /// </param>
        /// <param name="status"></param>
        /// <param name="statusCode"></param>
        /// <param name="transforms"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetRoutesResponseVariant3RouteRoute(
            string src,
            bool? caseSensitive,
            bool? check,
            bool? @continue,
            string? dest,
            global::Vercel.OneOf<string, global::Vercel.GetRoutesResponseVariant3RouteRouteDestination>? destination,
            global::System.Collections.Generic.IList<string>? env,
            global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.GetRoutesResponseVariant3RouteRouteHaVariant1, global::Vercel.GetRoutesResponseVariant3RouteRouteHaVariant2>>? has,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            bool? important,
            global::Vercel.GetRoutesResponseVariant3RouteRouteLocale? locale,
            global::System.Collections.Generic.IList<string>? methods,
            double? middleware,
            string? middlewarePath,
            global::System.Collections.Generic.IList<string>? middlewareRawSrc,
            global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.GetRoutesResponseVariant3RouteRouteMissingItemVariant1, global::Vercel.GetRoutesResponseVariant3RouteRouteMissingItemVariant2>>? missing,
            global::Vercel.GetRoutesResponseVariant3RouteRouteMitigate? mitigate,
            bool? @override,
            bool? respectOriginCacheControl,
            string? source,
            double? status,
            double? statusCode,
            global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.GetRoutesResponseVariant3RouteRouteTransformVariant1, global::Vercel.GetRoutesResponseVariant3RouteRouteTransformVariant2>>? transforms)
        {
            this.CaseSensitive = caseSensitive;
            this.Check = check;
            this.Continue = @continue;
            this.Dest = dest;
            this.Destination = destination;
            this.Env = env;
            this.Has = has;
            this.Headers = headers;
            this.Important = important;
            this.Locale = locale;
            this.Methods = methods;
            this.Middleware = middleware;
            this.MiddlewarePath = middlewarePath;
            this.MiddlewareRawSrc = middlewareRawSrc;
            this.Missing = missing;
            this.Mitigate = mitigate;
            this.Override = @override;
            this.RespectOriginCacheControl = respectOriginCacheControl;
            this.Source = source;
            this.Src = src ?? throw new global::System.ArgumentNullException(nameof(src));
            this.Status = status;
            this.StatusCode = statusCode;
            this.Transforms = transforms;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRoutesResponseVariant3RouteRoute" /> class.
        /// </summary>
        public GetRoutesResponseVariant3RouteRoute()
        {
        }

    }
}