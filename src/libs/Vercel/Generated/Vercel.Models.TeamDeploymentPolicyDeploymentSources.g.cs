
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Restricts which deployment sources are allowed. A deployment passes if its source is in `sources`. Multiple entries are evaluated as OR. `enabled: true` with an empty `sources` list is treated as deny-all.
    /// </summary>
    public sealed partial class TeamDeploymentPolicyDeploymentSources
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sources")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.TeamDeploymentPolicyDeploymentSourcesSource> Sources { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamDeploymentPolicyDeploymentSources" /> class.
        /// </summary>
        /// <param name="sources"></param>
        /// <param name="enabled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamDeploymentPolicyDeploymentSources(
            global::System.Collections.Generic.IList<global::Vercel.TeamDeploymentPolicyDeploymentSourcesSource> sources,
            bool enabled)
        {
            this.Sources = sources ?? throw new global::System.ArgumentNullException(nameof(sources));
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamDeploymentPolicyDeploymentSources" /> class.
        /// </summary>
        public TeamDeploymentPolicyDeploymentSources()
        {
        }

    }
}