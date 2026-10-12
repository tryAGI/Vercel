
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Password protection settings returned without the secret password hash.
    /// </summary>
    public sealed partial class GetMicrofrontendsInGroupResponseProjectPasswordProtection
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetMicrofrontendsInGroupResponseProjectPasswordProtectionDeploymentTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetMicrofrontendsInGroupResponseProjectPasswordProtectionDeploymentType DeploymentType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMicrofrontendsInGroupResponseProjectPasswordProtection" /> class.
        /// </summary>
        /// <param name="deploymentType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetMicrofrontendsInGroupResponseProjectPasswordProtection(
            global::Vercel.GetMicrofrontendsInGroupResponseProjectPasswordProtectionDeploymentType deploymentType)
        {
            this.DeploymentType = deploymentType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMicrofrontendsInGroupResponseProjectPasswordProtection" /> class.
        /// </summary>
        public GetMicrofrontendsInGroupResponseProjectPasswordProtection()
        {
        }

    }
}