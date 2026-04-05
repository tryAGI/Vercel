
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StageRoutesRequestRouteRouteTransform
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.StageRoutesRequestRouteRouteTransformTypeJsonConverter))]
        public global::Vercel.StageRoutesRequestRouteRouteTransformType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("op")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.StageRoutesRequestRouteRouteTransformOpJsonConverter))]
        public global::Vercel.StageRoutesRequestRouteRouteTransformOp? Op { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        public object? Target { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("args")]
        public object? Args { get; set; }

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
        /// Initializes a new instance of the <see cref="StageRoutesRequestRouteRouteTransform" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="op"></param>
        /// <param name="target"></param>
        /// <param name="args"></param>
        /// <param name="env"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StageRoutesRequestRouteRouteTransform(
            global::Vercel.StageRoutesRequestRouteRouteTransformType? type,
            global::Vercel.StageRoutesRequestRouteRouteTransformOp? op,
            object? target,
            object? args,
            global::System.Collections.Generic.IList<string>? env)
        {
            this.Type = type;
            this.Op = op;
            this.Target = target;
            this.Args = args;
            this.Env = env;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StageRoutesRequestRouteRouteTransform" /> class.
        /// </summary>
        public StageRoutesRequestRouteRouteTransform()
        {
        }
    }
}