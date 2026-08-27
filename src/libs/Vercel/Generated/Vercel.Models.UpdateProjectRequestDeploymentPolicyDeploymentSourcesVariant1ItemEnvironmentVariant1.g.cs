
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateProjectRequestDeploymentPolicyDeploymentSourcesVariant1ItemEnvironmentVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateProjectRequestDeploymentPolicyDeploymentSourcesVariant1ItemEnvironmentVariant1TypeJsonConverter))]
        public global::Vercel.UpdateProjectRequestDeploymentPolicyDeploymentSourcesVariant1ItemEnvironmentVariant1Type Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateProjectRequestDeploymentPolicyDeploymentSourcesVariant1ItemEnvironmentVariant1TargetJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpdateProjectRequestDeploymentPolicyDeploymentSourcesVariant1ItemEnvironmentVariant1Target Target { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequestDeploymentPolicyDeploymentSourcesVariant1ItemEnvironmentVariant1" /> class.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateProjectRequestDeploymentPolicyDeploymentSourcesVariant1ItemEnvironmentVariant1(
            global::Vercel.UpdateProjectRequestDeploymentPolicyDeploymentSourcesVariant1ItemEnvironmentVariant1Target target,
            global::Vercel.UpdateProjectRequestDeploymentPolicyDeploymentSourcesVariant1ItemEnvironmentVariant1Type type)
        {
            this.Type = type;
            this.Target = target;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequestDeploymentPolicyDeploymentSourcesVariant1ItemEnvironmentVariant1" /> class.
        /// </summary>
        public UpdateProjectRequestDeploymentPolicyDeploymentSourcesVariant1ItemEnvironmentVariant1()
        {
        }

    }
}