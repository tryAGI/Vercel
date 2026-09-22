
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateDeploymentResponseVariant2RouteVariant1TransformVariant2
    {
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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("op")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateDeploymentResponseVariant2RouteVariant1TransformVariant2OpJsonConverter))]
        public global::Vercel.CreateDeploymentResponseVariant2RouteVariant1TransformVariant2Op Op { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateDeploymentResponseVariant2RouteVariant1TransformVariant2TypeJsonConverter))]
        public global::Vercel.CreateDeploymentResponseVariant2RouteVariant1TransformVariant2Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseVariant2RouteVariant1TransformVariant2" /> class.
        /// </summary>
        /// <param name="args"></param>
        /// <param name="env"></param>
        /// <param name="op"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDeploymentResponseVariant2RouteVariant1TransformVariant2(
            string args,
            global::System.Collections.Generic.IList<string>? env,
            global::Vercel.CreateDeploymentResponseVariant2RouteVariant1TransformVariant2Op op,
            global::Vercel.CreateDeploymentResponseVariant2RouteVariant1TransformVariant2Type type)
        {
            this.Args = args ?? throw new global::System.ArgumentNullException(nameof(args));
            this.Env = env;
            this.Op = op;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseVariant2RouteVariant1TransformVariant2" /> class.
        /// </summary>
        public CreateDeploymentResponseVariant2RouteVariant1TransformVariant2()
        {
        }

    }
}