
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Where was the deployment created from<br/>
    /// Example: cli
    /// </summary>
    public enum GetRollingReleaseResponseRollingReleaseCurrentDeploymentSource
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
    public static class GetRollingReleaseResponseRollingReleaseCurrentDeploymentSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRollingReleaseResponseRollingReleaseCurrentDeploymentSource value)
        {
            return value switch
            {
                GetRollingReleaseResponseRollingReleaseCurrentDeploymentSource.ApiTriggerGitDeploy => "api-trigger-git-deploy",
                GetRollingReleaseResponseRollingReleaseCurrentDeploymentSource.Cli => "cli",
                GetRollingReleaseResponseRollingReleaseCurrentDeploymentSource.CloneRepo => "clone/repo",
                GetRollingReleaseResponseRollingReleaseCurrentDeploymentSource.Git => "git",
                GetRollingReleaseResponseRollingReleaseCurrentDeploymentSource.Import => "import",
                GetRollingReleaseResponseRollingReleaseCurrentDeploymentSource.ImportRepo => "import/repo",
                GetRollingReleaseResponseRollingReleaseCurrentDeploymentSource.Redeploy => "redeploy",
                GetRollingReleaseResponseRollingReleaseCurrentDeploymentSource.V0Web => "v0-web",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRollingReleaseResponseRollingReleaseCurrentDeploymentSource? ToEnum(string value)
        {
            return value switch
            {
                "api-trigger-git-deploy" => GetRollingReleaseResponseRollingReleaseCurrentDeploymentSource.ApiTriggerGitDeploy,
                "cli" => GetRollingReleaseResponseRollingReleaseCurrentDeploymentSource.Cli,
                "clone/repo" => GetRollingReleaseResponseRollingReleaseCurrentDeploymentSource.CloneRepo,
                "git" => GetRollingReleaseResponseRollingReleaseCurrentDeploymentSource.Git,
                "import" => GetRollingReleaseResponseRollingReleaseCurrentDeploymentSource.Import,
                "import/repo" => GetRollingReleaseResponseRollingReleaseCurrentDeploymentSource.ImportRepo,
                "redeploy" => GetRollingReleaseResponseRollingReleaseCurrentDeploymentSource.Redeploy,
                "v0-web" => GetRollingReleaseResponseRollingReleaseCurrentDeploymentSource.V0Web,
                _ => null,
            };
        }
    }
}