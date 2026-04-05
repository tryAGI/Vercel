
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Condensed check data. Retrieve individual check and check run data using api-checks v2 routes.
    /// </summary>
    public sealed partial class CreateDeploymentResponseChecksDeploymentAlias
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateDeploymentResponseChecksDeploymentAliasStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateDeploymentResponseChecksDeploymentAliasState State { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseChecksDeploymentAlias" /> class.
        /// </summary>
        /// <param name="state"></param>
        /// <param name="startedAt"></param>
        /// <param name="completedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDeploymentResponseChecksDeploymentAlias(
            global::Vercel.CreateDeploymentResponseChecksDeploymentAliasState state,
            double startedAt,
            double? completedAt)
        {
            this.State = state;
            this.StartedAt = startedAt;
            this.CompletedAt = completedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseChecksDeploymentAlias" /> class.
        /// </summary>
        public CreateDeploymentResponseChecksDeploymentAlias()
        {
        }
    }
}