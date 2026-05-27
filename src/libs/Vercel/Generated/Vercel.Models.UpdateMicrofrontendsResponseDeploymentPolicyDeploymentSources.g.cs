
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Restricts which deployment sources are allowed. A deployment passes if its source is in `sources`. Multiple entries are evaluated as OR. `enabled: true` with an empty `sources` list is treated as deny-all.
    /// </summary>
    public sealed partial class UpdateMicrofrontendsResponseDeploymentPolicyDeploymentSources
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sources")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.UpdateMicrofrontendsResponseDeploymentPolicyDeploymentSourcesSource> Sources { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        public global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.UpdateMicrofrontendsResponseDeploymentPolicyDeploymentSourcesEnvironmentVariant1, global::Vercel.UpdateMicrofrontendsResponseDeploymentPolicyDeploymentSourcesEnvironmentVariant2>>? Environments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMicrofrontendsResponseDeploymentPolicyDeploymentSources" /> class.
        /// </summary>
        /// <param name="sources"></param>
        /// <param name="enabled"></param>
        /// <param name="id"></param>
        /// <param name="environments"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateMicrofrontendsResponseDeploymentPolicyDeploymentSources(
            global::System.Collections.Generic.IList<global::Vercel.UpdateMicrofrontendsResponseDeploymentPolicyDeploymentSourcesSource> sources,
            bool enabled,
            string? id,
            global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.UpdateMicrofrontendsResponseDeploymentPolicyDeploymentSourcesEnvironmentVariant1, global::Vercel.UpdateMicrofrontendsResponseDeploymentPolicyDeploymentSourcesEnvironmentVariant2>>? environments)
        {
            this.Sources = sources ?? throw new global::System.ArgumentNullException(nameof(sources));
            this.Id = id;
            this.Enabled = enabled;
            this.Environments = environments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMicrofrontendsResponseDeploymentPolicyDeploymentSources" /> class.
        /// </summary>
        public UpdateMicrofrontendsResponseDeploymentPolicyDeploymentSources()
        {
        }

    }
}