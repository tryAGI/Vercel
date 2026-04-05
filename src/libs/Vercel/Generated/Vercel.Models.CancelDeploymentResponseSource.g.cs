
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Where was the deployment created from<br/>
    /// Example: cli
    /// </summary>
    public enum CancelDeploymentResponseSource
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
    public static class CancelDeploymentResponseSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseSource value)
        {
            return value switch
            {
                CancelDeploymentResponseSource.ApiTriggerGitDeploy => "api-trigger-git-deploy",
                CancelDeploymentResponseSource.Cli => "cli",
                CancelDeploymentResponseSource.CloneRepo => "clone/repo",
                CancelDeploymentResponseSource.Git => "git",
                CancelDeploymentResponseSource.Import => "import",
                CancelDeploymentResponseSource.ImportRepo => "import/repo",
                CancelDeploymentResponseSource.Redeploy => "redeploy",
                CancelDeploymentResponseSource.V0Web => "v0-web",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseSource? ToEnum(string value)
        {
            return value switch
            {
                "api-trigger-git-deploy" => CancelDeploymentResponseSource.ApiTriggerGitDeploy,
                "cli" => CancelDeploymentResponseSource.Cli,
                "clone/repo" => CancelDeploymentResponseSource.CloneRepo,
                "git" => CancelDeploymentResponseSource.Git,
                "import" => CancelDeploymentResponseSource.Import,
                "import/repo" => CancelDeploymentResponseSource.ImportRepo,
                "redeploy" => CancelDeploymentResponseSource.Redeploy,
                "v0-web" => CancelDeploymentResponseSource.V0Web,
                _ => null,
            };
        }
    }
}