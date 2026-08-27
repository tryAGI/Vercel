
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetRoutesResponseVariant4RouteRouteTransformVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetRoutesResponseVariant4RouteRouteTransformVariant2TypeJsonConverter))]
        public global::Vercel.GetRoutesResponseVariant4RouteRouteTransformVariant2Type Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("op")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetRoutesResponseVariant4RouteRouteTransformVariant2OpJsonConverter))]
        public global::Vercel.GetRoutesResponseVariant4RouteRouteTransformVariant2Op Op { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("args")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Args { get; set; }

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
        /// Initializes a new instance of the <see cref="GetRoutesResponseVariant4RouteRouteTransformVariant2" /> class.
        /// </summary>
        /// <param name="args"></param>
        /// <param name="type"></param>
        /// <param name="op"></param>
        /// <param name="env"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetRoutesResponseVariant4RouteRouteTransformVariant2(
            string args,
            global::Vercel.GetRoutesResponseVariant4RouteRouteTransformVariant2Type type,
            global::Vercel.GetRoutesResponseVariant4RouteRouteTransformVariant2Op op,
            global::System.Collections.Generic.IList<string>? env)
        {
            this.Type = type;
            this.Op = op;
            this.Args = args ?? throw new global::System.ArgumentNullException(nameof(args));
            this.Env = env;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRoutesResponseVariant4RouteRouteTransformVariant2" /> class.
        /// </summary>
        public GetRoutesResponseVariant4RouteRouteTransformVariant2()
        {
        }

    }
}