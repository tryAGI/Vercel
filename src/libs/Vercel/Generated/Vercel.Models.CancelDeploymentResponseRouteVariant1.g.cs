
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CancelDeploymentResponseRouteVariant1
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
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("methods")]
        public global::System.Collections.Generic.IList<string>? Methods { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("continue")]
        public bool? Continue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("override")]
        public bool? Override { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("important")]
        public bool? Important { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public double? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has")]
        public global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.CancelDeploymentResponseRouteVariant1HaVariant1, global::Vercel.CancelDeploymentResponseRouteVariant1HaVariant2>>? Has { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("missing")]
        public global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.CancelDeploymentResponseRouteVariant1MissingItemVariant1, global::Vercel.CancelDeploymentResponseRouteVariant1MissingItemVariant2>>? Missing { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mitigate")]
        public global::Vercel.CancelDeploymentResponseRouteVariant1Mitigate? Mitigate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transforms")]
        public global::System.Collections.Generic.IList<global::Vercel.CancelDeploymentResponseRouteVariant1Transform>? Transforms { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("env")]
        public global::System.Collections.Generic.IList<string>? Env { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locale")]
        public global::Vercel.CancelDeploymentResponseRouteVariant1Locale? Locale { get; set; }

        /// <summary>
        /// Aliases for `src`, `dest`, and `status`. These provide consistency with the `rewrites`, `redirects`, and `headers` fields which use `source`, `destination`, and `statusCode`. During normalization, these are converted to their canonical forms (`src`, `dest`, `status`) and stripped from the route object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destination")]
        public string? Destination { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statusCode")]
        public double? StatusCode { get; set; }

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
        /// A middleware index in the `middleware` key under the build result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("middleware")]
        public double? Middleware { get; set; }

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
        /// Initializes a new instance of the <see cref="CancelDeploymentResponseRouteVariant1" /> class.
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dest"></param>
        /// <param name="headers"></param>
        /// <param name="methods"></param>
        /// <param name="continue"></param>
        /// <param name="override"></param>
        /// <param name="caseSensitive"></param>
        /// <param name="check"></param>
        /// <param name="important"></param>
        /// <param name="status"></param>
        /// <param name="has"></param>
        /// <param name="missing"></param>
        /// <param name="mitigate"></param>
        /// <param name="transforms"></param>
        /// <param name="env"></param>
        /// <param name="locale"></param>
        /// <param name="source">
        /// Aliases for `src`, `dest`, and `status`. These provide consistency with the `rewrites`, `redirects`, and `headers` fields which use `source`, `destination`, and `statusCode`. During normalization, these are converted to their canonical forms (`src`, `dest`, `status`) and stripped from the route object.
        /// </param>
        /// <param name="destination"></param>
        /// <param name="statusCode"></param>
        /// <param name="middlewarePath">
        /// A middleware key within the `output` key under the build result. Overrides a `middleware` definition.
        /// </param>
        /// <param name="middlewareRawSrc">
        /// The original middleware matchers.
        /// </param>
        /// <param name="middleware">
        /// A middleware index in the `middleware` key under the build result
        /// </param>
        /// <param name="respectOriginCacheControl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CancelDeploymentResponseRouteVariant1(
            string src,
            string? dest,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            global::System.Collections.Generic.IList<string>? methods,
            bool? @continue,
            bool? @override,
            bool? caseSensitive,
            bool? check,
            bool? important,
            double? status,
            global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.CancelDeploymentResponseRouteVariant1HaVariant1, global::Vercel.CancelDeploymentResponseRouteVariant1HaVariant2>>? has,
            global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.CancelDeploymentResponseRouteVariant1MissingItemVariant1, global::Vercel.CancelDeploymentResponseRouteVariant1MissingItemVariant2>>? missing,
            global::Vercel.CancelDeploymentResponseRouteVariant1Mitigate? mitigate,
            global::System.Collections.Generic.IList<global::Vercel.CancelDeploymentResponseRouteVariant1Transform>? transforms,
            global::System.Collections.Generic.IList<string>? env,
            global::Vercel.CancelDeploymentResponseRouteVariant1Locale? locale,
            string? source,
            string? destination,
            double? statusCode,
            string? middlewarePath,
            global::System.Collections.Generic.IList<string>? middlewareRawSrc,
            double? middleware,
            bool? respectOriginCacheControl)
        {
            this.Src = src ?? throw new global::System.ArgumentNullException(nameof(src));
            this.Dest = dest;
            this.Headers = headers;
            this.Methods = methods;
            this.Continue = @continue;
            this.Override = @override;
            this.CaseSensitive = caseSensitive;
            this.Check = check;
            this.Important = important;
            this.Status = status;
            this.Has = has;
            this.Missing = missing;
            this.Mitigate = mitigate;
            this.Transforms = transforms;
            this.Env = env;
            this.Locale = locale;
            this.Source = source;
            this.Destination = destination;
            this.StatusCode = statusCode;
            this.MiddlewarePath = middlewarePath;
            this.MiddlewareRawSrc = middlewareRawSrc;
            this.Middleware = middleware;
            this.RespectOriginCacheControl = respectOriginCacheControl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelDeploymentResponseRouteVariant1" /> class.
        /// </summary>
        public CancelDeploymentResponseRouteVariant1()
        {
        }
    }
}