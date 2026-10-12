
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Password protection settings returned without the secret password hash.
    /// </summary>
    public sealed partial class AutoSDKSharedba7c6b12ca723bfbPasswordProtection
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedba7c6b12ca723bfbPasswordProtectionDeploymentTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedba7c6b12ca723bfbPasswordProtectionDeploymentType DeploymentType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedba7c6b12ca723bfbPasswordProtection" /> class.
        /// </summary>
        /// <param name="deploymentType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedba7c6b12ca723bfbPasswordProtection(
            global::Vercel.AutoSDKSharedba7c6b12ca723bfbPasswordProtectionDeploymentType deploymentType)
        {
            this.DeploymentType = deploymentType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedba7c6b12ca723bfbPasswordProtection" /> class.
        /// </summary>
        public AutoSDKSharedba7c6b12ca723bfbPasswordProtection()
        {
        }

    }
}