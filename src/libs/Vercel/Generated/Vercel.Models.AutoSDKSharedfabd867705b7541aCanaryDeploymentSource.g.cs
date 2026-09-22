
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Where was the deployment created from. Best-effort guess for metrics only — not authoritative; do not gate behavior on it.<br/>
    /// Example: cli
    /// </summary>
    public enum AutoSDKSharedfabd867705b7541aCanaryDeploymentSource
    {
        /// <summary>
        ///
        /// </summary>
        ApiTriggerGitDeploy,
        /// <summary>
        ///
        /// </summary>
        Cli,
        /// <summary>
        ///
        /// </summary>
        CloneRepo,
        /// <summary>
        ///
        /// </summary>
        Drop,
        /// <summary>
        ///
        /// </summary>
        Git,
        /// <summary>
        ///
        /// </summary>
        GitDeployHook,
        /// <summary>
        ///
        /// </summary>
        Import,
        /// <summary>
        ///
        /// </summary>
        ImportRepo,
        /// <summary>
        ///
        /// </summary>
        Redeploy,
        /// <summary>
        ///
        /// </summary>
        V0Web,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedfabd867705b7541aCanaryDeploymentSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedfabd867705b7541aCanaryDeploymentSource value)
        {
            return value switch
            {
                AutoSDKSharedfabd867705b7541aCanaryDeploymentSource.ApiTriggerGitDeploy => "api-trigger-git-deploy",
                AutoSDKSharedfabd867705b7541aCanaryDeploymentSource.Cli => "cli",
                AutoSDKSharedfabd867705b7541aCanaryDeploymentSource.CloneRepo => "clone/repo",
                AutoSDKSharedfabd867705b7541aCanaryDeploymentSource.Drop => "drop",
                AutoSDKSharedfabd867705b7541aCanaryDeploymentSource.Git => "git",
                AutoSDKSharedfabd867705b7541aCanaryDeploymentSource.GitDeployHook => "git-deploy-hook",
                AutoSDKSharedfabd867705b7541aCanaryDeploymentSource.Import => "import",
                AutoSDKSharedfabd867705b7541aCanaryDeploymentSource.ImportRepo => "import/repo",
                AutoSDKSharedfabd867705b7541aCanaryDeploymentSource.Redeploy => "redeploy",
                AutoSDKSharedfabd867705b7541aCanaryDeploymentSource.V0Web => "v0-web",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedfabd867705b7541aCanaryDeploymentSource? ToEnum(string value)
        {
            return value switch
            {
                "api-trigger-git-deploy" => AutoSDKSharedfabd867705b7541aCanaryDeploymentSource.ApiTriggerGitDeploy,
                "cli" => AutoSDKSharedfabd867705b7541aCanaryDeploymentSource.Cli,
                "clone/repo" => AutoSDKSharedfabd867705b7541aCanaryDeploymentSource.CloneRepo,
                "drop" => AutoSDKSharedfabd867705b7541aCanaryDeploymentSource.Drop,
                "git" => AutoSDKSharedfabd867705b7541aCanaryDeploymentSource.Git,
                "git-deploy-hook" => AutoSDKSharedfabd867705b7541aCanaryDeploymentSource.GitDeployHook,
                "import" => AutoSDKSharedfabd867705b7541aCanaryDeploymentSource.Import,
                "import/repo" => AutoSDKSharedfabd867705b7541aCanaryDeploymentSource.ImportRepo,
                "redeploy" => AutoSDKSharedfabd867705b7541aCanaryDeploymentSource.Redeploy,
                "v0-web" => AutoSDKSharedfabd867705b7541aCanaryDeploymentSource.V0Web,
                _ => null,
            };
        }
    }
}