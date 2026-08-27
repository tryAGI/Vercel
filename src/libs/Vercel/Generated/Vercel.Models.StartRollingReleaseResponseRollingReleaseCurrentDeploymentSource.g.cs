
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Where was the deployment created from. Best-effort guess for metrics only — not authoritative; do not gate behavior on it.<br/>
    /// Example: cli
    /// </summary>
    public enum StartRollingReleaseResponseRollingReleaseCurrentDeploymentSource
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
    public static class StartRollingReleaseResponseRollingReleaseCurrentDeploymentSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StartRollingReleaseResponseRollingReleaseCurrentDeploymentSource value)
        {
            return value switch
            {
                StartRollingReleaseResponseRollingReleaseCurrentDeploymentSource.ApiTriggerGitDeploy => "api-trigger-git-deploy",
                StartRollingReleaseResponseRollingReleaseCurrentDeploymentSource.Cli => "cli",
                StartRollingReleaseResponseRollingReleaseCurrentDeploymentSource.CloneRepo => "clone/repo",
                StartRollingReleaseResponseRollingReleaseCurrentDeploymentSource.Drop => "drop",
                StartRollingReleaseResponseRollingReleaseCurrentDeploymentSource.Git => "git",
                StartRollingReleaseResponseRollingReleaseCurrentDeploymentSource.GitDeployHook => "git-deploy-hook",
                StartRollingReleaseResponseRollingReleaseCurrentDeploymentSource.Import => "import",
                StartRollingReleaseResponseRollingReleaseCurrentDeploymentSource.ImportRepo => "import/repo",
                StartRollingReleaseResponseRollingReleaseCurrentDeploymentSource.Redeploy => "redeploy",
                StartRollingReleaseResponseRollingReleaseCurrentDeploymentSource.V0Web => "v0-web",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StartRollingReleaseResponseRollingReleaseCurrentDeploymentSource? ToEnum(string value)
        {
            return value switch
            {
                "api-trigger-git-deploy" => StartRollingReleaseResponseRollingReleaseCurrentDeploymentSource.ApiTriggerGitDeploy,
                "cli" => StartRollingReleaseResponseRollingReleaseCurrentDeploymentSource.Cli,
                "clone/repo" => StartRollingReleaseResponseRollingReleaseCurrentDeploymentSource.CloneRepo,
                "drop" => StartRollingReleaseResponseRollingReleaseCurrentDeploymentSource.Drop,
                "git" => StartRollingReleaseResponseRollingReleaseCurrentDeploymentSource.Git,
                "git-deploy-hook" => StartRollingReleaseResponseRollingReleaseCurrentDeploymentSource.GitDeployHook,
                "import" => StartRollingReleaseResponseRollingReleaseCurrentDeploymentSource.Import,
                "import/repo" => StartRollingReleaseResponseRollingReleaseCurrentDeploymentSource.ImportRepo,
                "redeploy" => StartRollingReleaseResponseRollingReleaseCurrentDeploymentSource.Redeploy,
                "v0-web" => StartRollingReleaseResponseRollingReleaseCurrentDeploymentSource.V0Web,
                _ => null,
            };
        }
    }
}