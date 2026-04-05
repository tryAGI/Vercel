
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Where was the deployment created from<br/>
    /// Example: cli
    /// </summary>
    public enum ApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentSource
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
    public static class ApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentSource value)
        {
            return value switch
            {
                ApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentSource.ApiTriggerGitDeploy => "api-trigger-git-deploy",
                ApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentSource.Cli => "cli",
                ApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentSource.CloneRepo => "clone/repo",
                ApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentSource.Git => "git",
                ApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentSource.Import => "import",
                ApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentSource.ImportRepo => "import/repo",
                ApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentSource.Redeploy => "redeploy",
                ApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentSource.V0Web => "v0-web",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentSource? ToEnum(string value)
        {
            return value switch
            {
                "api-trigger-git-deploy" => ApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentSource.ApiTriggerGitDeploy,
                "cli" => ApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentSource.Cli,
                "clone/repo" => ApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentSource.CloneRepo,
                "git" => ApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentSource.Git,
                "import" => ApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentSource.Import,
                "import/repo" => ApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentSource.ImportRepo,
                "redeploy" => ApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentSource.Redeploy,
                "v0-web" => ApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentSource.V0Web,
                _ => null,
            };
        }
    }
}