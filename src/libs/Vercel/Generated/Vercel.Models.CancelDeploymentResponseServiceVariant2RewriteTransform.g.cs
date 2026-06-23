
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CancelDeploymentResponseServiceVariant2RewriteTransform
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CancelDeploymentResponseServiceVariant2RewriteTransformTypeJsonConverter))]
        public global::Vercel.CancelDeploymentResponseServiceVariant2RewriteTransformType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("op")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CancelDeploymentResponseServiceVariant2RewriteTransformOpJsonConverter))]
        public global::Vercel.CancelDeploymentResponseServiceVariant2RewriteTransformOp Op { get; set; }

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
        /// Initializes a new instance of the <see cref="CancelDeploymentResponseServiceVariant2RewriteTransform" /> class.
        /// </summary>
        /// <param name="args"></param>
        /// <param name="type"></param>
        /// <param name="op"></param>
        /// <param name="env"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CancelDeploymentResponseServiceVariant2RewriteTransform(
            string args,
            global::Vercel.CancelDeploymentResponseServiceVariant2RewriteTransformType type,
            global::Vercel.CancelDeploymentResponseServiceVariant2RewriteTransformOp op,
            global::System.Collections.Generic.IList<string>? env)
        {
            this.Type = type;
            this.Op = op;
            this.Args = args ?? throw new global::System.ArgumentNullException(nameof(args));
            this.Env = env;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelDeploymentResponseServiceVariant2RewriteTransform" /> class.
        /// </summary>
        public CancelDeploymentResponseServiceVariant2RewriteTransform()
        {
        }

    }
}