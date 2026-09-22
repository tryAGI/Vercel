
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Where was the deployment created from. Best-effort guess for metrics only — not authoritative; do not gate behavior on it.<br/>
    /// Example: cli
    /// </summary>
    public enum AutoSDKSharedfabd867705b7541aCurrentDeploymentSource
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
    public static class AutoSDKSharedfabd867705b7541aCurrentDeploymentSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedfabd867705b7541aCurrentDeploymentSource value)
        {
            return value switch
            {
                AutoSDKSharedfabd867705b7541aCurrentDeploymentSource.ApiTriggerGitDeploy => "api-trigger-git-deploy",
                AutoSDKSharedfabd867705b7541aCurrentDeploymentSource.Cli => "cli",
                AutoSDKSharedfabd867705b7541aCurrentDeploymentSource.CloneRepo => "clone/repo",
                AutoSDKSharedfabd867705b7541aCurrentDeploymentSource.Drop => "drop",
                AutoSDKSharedfabd867705b7541aCurrentDeploymentSource.Git => "git",
                AutoSDKSharedfabd867705b7541aCurrentDeploymentSource.GitDeployHook => "git-deploy-hook",
                AutoSDKSharedfabd867705b7541aCurrentDeploymentSource.Import => "import",
                AutoSDKSharedfabd867705b7541aCurrentDeploymentSource.ImportRepo => "import/repo",
                AutoSDKSharedfabd867705b7541aCurrentDeploymentSource.Redeploy => "redeploy",
                AutoSDKSharedfabd867705b7541aCurrentDeploymentSource.V0Web => "v0-web",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedfabd867705b7541aCurrentDeploymentSource? ToEnum(string value)
        {
            return value switch
            {
                "api-trigger-git-deploy" => AutoSDKSharedfabd867705b7541aCurrentDeploymentSource.ApiTriggerGitDeploy,
                "cli" => AutoSDKSharedfabd867705b7541aCurrentDeploymentSource.Cli,
                "clone/repo" => AutoSDKSharedfabd867705b7541aCurrentDeploymentSource.CloneRepo,
                "drop" => AutoSDKSharedfabd867705b7541aCurrentDeploymentSource.Drop,
                "git" => AutoSDKSharedfabd867705b7541aCurrentDeploymentSource.Git,
                "git-deploy-hook" => AutoSDKSharedfabd867705b7541aCurrentDeploymentSource.GitDeployHook,
                "import" => AutoSDKSharedfabd867705b7541aCurrentDeploymentSource.Import,
                "import/repo" => AutoSDKSharedfabd867705b7541aCurrentDeploymentSource.ImportRepo,
                "redeploy" => AutoSDKSharedfabd867705b7541aCurrentDeploymentSource.Redeploy,
                "v0-web" => AutoSDKSharedfabd867705b7541aCurrentDeploymentSource.V0Web,
                _ => null,
            };
        }
    }
}