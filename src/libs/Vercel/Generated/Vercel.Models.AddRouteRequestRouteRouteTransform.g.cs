
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddRouteRequestRouteRouteTransform
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AddRouteRequestRouteRouteTransformTypeJsonConverter))]
        public global::Vercel.AddRouteRequestRouteRouteTransformType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("op")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AddRouteRequestRouteRouteTransformOpJsonConverter))]
        public global::Vercel.AddRouteRequestRouteRouteTransformOp? Op { get; set; }

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
        /// Initializes a new instance of the <see cref="AddRouteRequestRouteRouteTransform" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="op"></param>
        /// <param name="target"></param>
        /// <param name="args"></param>
        /// <param name="env"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddRouteRequestRouteRouteTransform(
            global::Vercel.AddRouteRequestRouteRouteTransformType? type,
            global::Vercel.AddRouteRequestRouteRouteTransformOp? op,
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
        /// Initializes a new instance of the <see cref="AddRouteRequestRouteRouteTransform" /> class.
        /// </summary>
        public AddRouteRequestRouteRouteTransform()
        {
        }
    }
}