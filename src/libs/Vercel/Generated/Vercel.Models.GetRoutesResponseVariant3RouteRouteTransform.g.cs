
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetRoutesResponseVariant3RouteRouteTransform
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetRoutesResponseVariant3RouteRouteTransformTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetRoutesResponseVariant3RouteRouteTransformType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("op")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetRoutesResponseVariant3RouteRouteTransformOpJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetRoutesResponseVariant3RouteRouteTransformOp Op { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetRoutesResponseVariant3RouteRouteTransformTarget Target { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("args")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::Vercel.OneOf<string, global::System.Collections.Generic.IList<string>>? Args { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("env")]
        public global::System.Collections.Generic.IList<string>? Env { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRoutesResponseVariant3RouteRouteTransform" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="op"></param>
        /// <param name="target"></param>
        /// <param name="args"></param>
        /// <param name="env"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetRoutesResponseVariant3RouteRouteTransform(
            global::Vercel.GetRoutesResponseVariant3RouteRouteTransformType type,
            global::Vercel.GetRoutesResponseVariant3RouteRouteTransformOp op,
            global::Vercel.GetRoutesResponseVariant3RouteRouteTransformTarget target,
            global::Vercel.OneOf<string, global::System.Collections.Generic.IList<string>>? args,
            global::System.Collections.Generic.IList<string>? env)
        {
            this.Type = type;
            this.Op = op;
            this.Target = target ?? throw new global::System.ArgumentNullException(nameof(target));
            this.Args = args;
            this.Env = env;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRoutesResponseVariant3RouteRouteTransform" /> class.
        /// </summary>
        public GetRoutesResponseVariant3RouteRouteTransform()
        {
        }
    }
}