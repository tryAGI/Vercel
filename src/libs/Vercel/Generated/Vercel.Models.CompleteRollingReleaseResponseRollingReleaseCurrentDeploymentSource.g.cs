
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Where was the deployment created from. Best-effort guess for metrics only — not authoritative; do not gate behavior on it.<br/>
    /// Example: cli
    /// </summary>
    public enum CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentSource
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
    public static class CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentSource value)
        {
            return value switch
            {
                CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentSource.ApiTriggerGitDeploy => "api-trigger-git-deploy",
                CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentSource.Cli => "cli",
                CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentSource.CloneRepo => "clone/repo",
                CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentSource.Drop => "drop",
                CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentSource.Git => "git",
                CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentSource.Import => "import",
                CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentSource.ImportRepo => "import/repo",
                CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentSource.Redeploy => "redeploy",
                CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentSource.V0Web => "v0-web",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentSource? ToEnum(string value)
        {
            return value switch
            {
                "api-trigger-git-deploy" => CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentSource.ApiTriggerGitDeploy,
                "cli" => CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentSource.Cli,
                "clone/repo" => CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentSource.CloneRepo,
                "drop" => CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentSource.Drop,
                "git" => CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentSource.Git,
                "import" => CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentSource.Import,
                "import/repo" => CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentSource.ImportRepo,
                "redeploy" => CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentSource.Redeploy,
                "v0-web" => CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentSource.V0Web,
                _ => null,
            };
        }
    }
}