
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CancelDeploymentResponseServiceVariant2RewriteDestination
    {
        /// <summary>
        /// Routing-only path used to select a route inside the target service.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Service { get; set; }

        /// <summary>
        /// Optional explicit format marker. The destination is identified by the presence of `service`, so `type` is no longer required.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CancelDeploymentResponseServiceVariant2RewriteDestinationTypeJsonConverter))]
        public global::Vercel.CancelDeploymentResponseServiceVariant2RewriteDestinationType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelDeploymentResponseServiceVariant2RewriteDestination" /> class.
        /// </summary>
        /// <param name="service"></param>
        /// <param name="path">
        /// Routing-only path used to select a route inside the target service.
        /// </param>
        /// <param name="type">
        /// Optional explicit format marker. The destination is identified by the presence of `service`, so `type` is no longer required.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CancelDeploymentResponseServiceVariant2RewriteDestination(
            string service,
            string? path,
            global::Vercel.CancelDeploymentResponseServiceVariant2RewriteDestinationType? type)
        {
            this.Path = path;
            this.Service = service ?? throw new global::System.ArgumentNullException(nameof(service));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelDeploymentResponseServiceVariant2RewriteDestination" /> class.
        /// </summary>
        public CancelDeploymentResponseServiceVariant2RewriteDestination()
        {
        }

    }
}