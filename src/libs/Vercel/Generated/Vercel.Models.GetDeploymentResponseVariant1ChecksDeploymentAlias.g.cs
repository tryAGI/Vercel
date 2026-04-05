
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Condensed check data. Retrieve individual check and check run data using api-checks v2 routes.
    /// </summary>
    public sealed partial class GetDeploymentResponseVariant1ChecksDeploymentAlias
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentResponseVariant1ChecksDeploymentAliasStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetDeploymentResponseVariant1ChecksDeploymentAliasState State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double StartedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completedAt")]
        public double? CompletedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentResponseVariant1ChecksDeploymentAlias" /> class.
        /// </summary>
        /// <param name="state"></param>
        /// <param name="startedAt"></param>
        /// <param name="completedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDeploymentResponseVariant1ChecksDeploymentAlias(
            global::Vercel.GetDeploymentResponseVariant1ChecksDeploymentAliasState state,
            double startedAt,
            double? completedAt)
        {
            this.State = state;
            this.StartedAt = startedAt;
            this.CompletedAt = completedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentResponseVariant1ChecksDeploymentAlias" /> class.
        /// </summary>
        public GetDeploymentResponseVariant1ChecksDeploymentAlias()
        {
        }
    }
}