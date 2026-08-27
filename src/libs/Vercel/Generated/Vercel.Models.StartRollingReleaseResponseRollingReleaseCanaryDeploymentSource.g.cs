
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Where was the deployment created from. Best-effort guess for metrics only — not authoritative; do not gate behavior on it.<br/>
    /// Example: cli
    /// </summary>
    public enum StartRollingReleaseResponseRollingReleaseCanaryDeploymentSource
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
    public static class StartRollingReleaseResponseRollingReleaseCanaryDeploymentSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StartRollingReleaseResponseRollingReleaseCanaryDeploymentSource value)
        {
            return value switch
            {
                StartRollingReleaseResponseRollingReleaseCanaryDeploymentSource.ApiTriggerGitDeploy => "api-trigger-git-deploy",
                StartRollingReleaseResponseRollingReleaseCanaryDeploymentSource.Cli => "cli",
                StartRollingReleaseResponseRollingReleaseCanaryDeploymentSource.CloneRepo => "clone/repo",
                StartRollingReleaseResponseRollingReleaseCanaryDeploymentSource.Drop => "drop",
                StartRollingReleaseResponseRollingReleaseCanaryDeploymentSource.Git => "git",
                StartRollingReleaseResponseRollingReleaseCanaryDeploymentSource.GitDeployHook => "git-deploy-hook",
                StartRollingReleaseResponseRollingReleaseCanaryDeploymentSource.Import => "import",
                StartRollingReleaseResponseRollingReleaseCanaryDeploymentSource.ImportRepo => "import/repo",
                StartRollingReleaseResponseRollingReleaseCanaryDeploymentSource.Redeploy => "redeploy",
                StartRollingReleaseResponseRollingReleaseCanaryDeploymentSource.V0Web => "v0-web",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StartRollingReleaseResponseRollingReleaseCanaryDeploymentSource? ToEnum(string value)
        {
            return value switch
            {
                "api-trigger-git-deploy" => StartRollingReleaseResponseRollingReleaseCanaryDeploymentSource.ApiTriggerGitDeploy,
                "cli" => StartRollingReleaseResponseRollingReleaseCanaryDeploymentSource.Cli,
                "clone/repo" => StartRollingReleaseResponseRollingReleaseCanaryDeploymentSource.CloneRepo,
                "drop" => StartRollingReleaseResponseRollingReleaseCanaryDeploymentSource.Drop,
                "git" => StartRollingReleaseResponseRollingReleaseCanaryDeploymentSource.Git,
                "git-deploy-hook" => StartRollingReleaseResponseRollingReleaseCanaryDeploymentSource.GitDeployHook,
                "import" => StartRollingReleaseResponseRollingReleaseCanaryDeploymentSource.Import,
                "import/repo" => StartRollingReleaseResponseRollingReleaseCanaryDeploymentSource.ImportRepo,
                "redeploy" => StartRollingReleaseResponseRollingReleaseCanaryDeploymentSource.Redeploy,
                "v0-web" => StartRollingReleaseResponseRollingReleaseCanaryDeploymentSource.V0Web,
                _ => null,
            };
        }
    }
}