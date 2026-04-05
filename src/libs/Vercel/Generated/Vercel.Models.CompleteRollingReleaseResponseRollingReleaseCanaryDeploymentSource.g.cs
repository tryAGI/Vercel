
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Where was the deployment created from<br/>
    /// Example: cli
    /// </summary>
    public enum CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentSource
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
    public static class CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentSource value)
        {
            return value switch
            {
                CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentSource.ApiTriggerGitDeploy => "api-trigger-git-deploy",
                CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentSource.Cli => "cli",
                CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentSource.CloneRepo => "clone/repo",
                CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentSource.Git => "git",
                CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentSource.Import => "import",
                CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentSource.ImportRepo => "import/repo",
                CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentSource.Redeploy => "redeploy",
                CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentSource.V0Web => "v0-web",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentSource? ToEnum(string value)
        {
            return value switch
            {
                "api-trigger-git-deploy" => CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentSource.ApiTriggerGitDeploy,
                "cli" => CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentSource.Cli,
                "clone/repo" => CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentSource.CloneRepo,
                "git" => CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentSource.Git,
                "import" => CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentSource.Import,
                "import/repo" => CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentSource.ImportRepo,
                "redeploy" => CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentSource.Redeploy,
                "v0-web" => CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentSource.V0Web,
                _ => null,
            };
        }
    }
}