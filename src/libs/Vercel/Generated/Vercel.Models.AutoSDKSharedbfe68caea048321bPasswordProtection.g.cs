
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Password protection settings returned without the secret password hash.
    /// </summary>
    public sealed partial class AutoSDKSharedbfe68caea048321bPasswordProtection
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedbfe68caea048321bPasswordProtectionDeploymentTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedbfe68caea048321bPasswordProtectionDeploymentType DeploymentType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedbfe68caea048321bPasswordProtection" /> class.
        /// </summary>
        /// <param name="deploymentType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedbfe68caea048321bPasswordProtection(
            global::Vercel.AutoSDKSharedbfe68caea048321bPasswordProtectionDeploymentType deploymentType)
        {
            this.DeploymentType = deploymentType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedbfe68caea048321bPasswordProtection" /> class.
        /// </summary>
        public AutoSDKSharedbfe68caea048321bPasswordProtection()
        {
        }

    }
}