
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CancelDeploymentResponseServiceVariant2Rewrite
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Source { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destination")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.CancelDeploymentResponseServiceVariant2RewriteDestination>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<string, global::Vercel.CancelDeploymentResponseServiceVariant2RewriteDestination> Destination { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transforms")]
        public global::System.Collections.Generic.IList<global::Vercel.CancelDeploymentResponseServiceVariant2RewriteTransform>? Transforms { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has")]
        public global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.CancelDeploymentResponseServiceVariant2RewriteHaVariant1, global::Vercel.CancelDeploymentResponseServiceVariant2RewriteHaVariant2>>? Has { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("missing")]
        public global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.CancelDeploymentResponseServiceVariant2RewriteMissingItemVariant1, global::Vercel.CancelDeploymentResponseServiceVariant2RewriteMissingItemVariant2>>? Missing { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statusCode")]
        public double? StatusCode { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("env")]
        public global::System.Collections.Generic.IList<string>? Env { get; set; }

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
        /// Initializes a new instance of the <see cref="CancelDeploymentResponseServiceVariant2Rewrite" /> class.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <param name="transforms"></param>
        /// <param name="has"></param>
        /// <param name="missing"></param>
        /// <param name="statusCode"></param>
        /// <param name="env"></param>
        /// <param name="respectOriginCacheControl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CancelDeploymentResponseServiceVariant2Rewrite(
            string source,
            global::Vercel.OneOf<string, global::Vercel.CancelDeploymentResponseServiceVariant2RewriteDestination> destination,
            global::System.Collections.Generic.IList<global::Vercel.CancelDeploymentResponseServiceVariant2RewriteTransform>? transforms,
            global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.CancelDeploymentResponseServiceVariant2RewriteHaVariant1, global::Vercel.CancelDeploymentResponseServiceVariant2RewriteHaVariant2>>? has,
            global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.CancelDeploymentResponseServiceVariant2RewriteMissingItemVariant1, global::Vercel.CancelDeploymentResponseServiceVariant2RewriteMissingItemVariant2>>? missing,
            double? statusCode,
            global::System.Collections.Generic.IList<string>? env,
            bool? respectOriginCacheControl)
        {
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Destination = destination;
            this.Transforms = transforms;
            this.Has = has;
            this.Missing = missing;
            this.StatusCode = statusCode;
            this.Env = env;
            this.RespectOriginCacheControl = respectOriginCacheControl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelDeploymentResponseServiceVariant2Rewrite" /> class.
        /// </summary>
        public CancelDeploymentResponseServiceVariant2Rewrite()
        {
        }

    }
}