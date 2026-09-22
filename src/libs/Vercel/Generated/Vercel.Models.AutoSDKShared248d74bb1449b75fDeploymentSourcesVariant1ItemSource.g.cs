
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared248d74bb1449b75fDeploymentSourcesVariant1ItemSource
    {
        /// <summary>
        ///
        /// </summary>
        Cli,
        /// <summary>
        ///
        /// </summary>
        DeployHook,
        /// <summary>
        ///
        /// </summary>
        Git,
        /// <summary>
        ///
        /// </summary>
        Integration,
        /// <summary>
        ///
        /// </summary>
        RestApi,
        /// <summary>
        ///
        /// </summary>
        V0,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared248d74bb1449b75fDeploymentSourcesVariant1ItemSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared248d74bb1449b75fDeploymentSourcesVariant1ItemSource value)
        {
            return value switch
            {
                AutoSDKShared248d74bb1449b75fDeploymentSourcesVariant1ItemSource.Cli => "cli",
                AutoSDKShared248d74bb1449b75fDeploymentSourcesVariant1ItemSource.DeployHook => "deploy-hook",
                AutoSDKShared248d74bb1449b75fDeploymentSourcesVariant1ItemSource.Git => "git",
                AutoSDKShared248d74bb1449b75fDeploymentSourcesVariant1ItemSource.Integration => "integration",
                AutoSDKShared248d74bb1449b75fDeploymentSourcesVariant1ItemSource.RestApi => "rest-api",
                AutoSDKShared248d74bb1449b75fDeploymentSourcesVariant1ItemSource.V0 => "v0",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared248d74bb1449b75fDeploymentSourcesVariant1ItemSource? ToEnum(string value)
        {
            return value switch
            {
                "cli" => AutoSDKShared248d74bb1449b75fDeploymentSourcesVariant1ItemSource.Cli,
                "deploy-hook" => AutoSDKShared248d74bb1449b75fDeploymentSourcesVariant1ItemSource.DeployHook,
                "git" => AutoSDKShared248d74bb1449b75fDeploymentSourcesVariant1ItemSource.Git,
                "integration" => AutoSDKShared248d74bb1449b75fDeploymentSourcesVariant1ItemSource.Integration,
                "rest-api" => AutoSDKShared248d74bb1449b75fDeploymentSourcesVariant1ItemSource.RestApi,
                "v0" => AutoSDKShared248d74bb1449b75fDeploymentSourcesVariant1ItemSource.V0,
                _ => null,
            };
        }
    }
}