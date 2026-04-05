
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Where was the deployment created from<br/>
    /// Example: cli
    /// </summary>
    public enum GetRollingReleaseResponseRollingReleaseCanaryDeploymentSource
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
    public static class GetRollingReleaseResponseRollingReleaseCanaryDeploymentSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRollingReleaseResponseRollingReleaseCanaryDeploymentSource value)
        {
            return value switch
            {
                GetRollingReleaseResponseRollingReleaseCanaryDeploymentSource.ApiTriggerGitDeploy => "api-trigger-git-deploy",
                GetRollingReleaseResponseRollingReleaseCanaryDeploymentSource.Cli => "cli",
                GetRollingReleaseResponseRollingReleaseCanaryDeploymentSource.CloneRepo => "clone/repo",
                GetRollingReleaseResponseRollingReleaseCanaryDeploymentSource.Git => "git",
                GetRollingReleaseResponseRollingReleaseCanaryDeploymentSource.Import => "import",
                GetRollingReleaseResponseRollingReleaseCanaryDeploymentSource.ImportRepo => "import/repo",
                GetRollingReleaseResponseRollingReleaseCanaryDeploymentSource.Redeploy => "redeploy",
                GetRollingReleaseResponseRollingReleaseCanaryDeploymentSource.V0Web => "v0-web",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRollingReleaseResponseRollingReleaseCanaryDeploymentSource? ToEnum(string value)
        {
            return value switch
            {
                "api-trigger-git-deploy" => GetRollingReleaseResponseRollingReleaseCanaryDeploymentSource.ApiTriggerGitDeploy,
                "cli" => GetRollingReleaseResponseRollingReleaseCanaryDeploymentSource.Cli,
                "clone/repo" => GetRollingReleaseResponseRollingReleaseCanaryDeploymentSource.CloneRepo,
                "git" => GetRollingReleaseResponseRollingReleaseCanaryDeploymentSource.Git,
                "import" => GetRollingReleaseResponseRollingReleaseCanaryDeploymentSource.Import,
                "import/repo" => GetRollingReleaseResponseRollingReleaseCanaryDeploymentSource.ImportRepo,
                "redeploy" => GetRollingReleaseResponseRollingReleaseCanaryDeploymentSource.Redeploy,
                "v0-web" => GetRollingReleaseResponseRollingReleaseCanaryDeploymentSource.V0Web,
                _ => null,
            };
        }
    }
}