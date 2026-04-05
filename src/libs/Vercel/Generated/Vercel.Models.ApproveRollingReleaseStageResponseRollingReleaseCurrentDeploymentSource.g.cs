
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Where was the deployment created from<br/>
    /// Example: cli
    /// </summary>
    public enum ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentSource
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
    public static class ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentSource value)
        {
            return value switch
            {
                ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentSource.ApiTriggerGitDeploy => "api-trigger-git-deploy",
                ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentSource.Cli => "cli",
                ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentSource.CloneRepo => "clone/repo",
                ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentSource.Git => "git",
                ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentSource.Import => "import",
                ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentSource.ImportRepo => "import/repo",
                ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentSource.Redeploy => "redeploy",
                ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentSource.V0Web => "v0-web",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentSource? ToEnum(string value)
        {
            return value switch
            {
                "api-trigger-git-deploy" => ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentSource.ApiTriggerGitDeploy,
                "cli" => ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentSource.Cli,
                "clone/repo" => ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentSource.CloneRepo,
                "git" => ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentSource.Git,
                "import" => ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentSource.Import,
                "import/repo" => ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentSource.ImportRepo,
                "redeploy" => ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentSource.Redeploy,
                "v0-web" => ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentSource.V0Web,
                _ => null,
            };
        }
    }
}