
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Where was the deployment created from<br/>
    /// Example: cli
    /// </summary>
    public enum CreateDeploymentResponseSource
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
    public static class CreateDeploymentResponseSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseSource value)
        {
            return value switch
            {
                CreateDeploymentResponseSource.ApiTriggerGitDeploy => "api-trigger-git-deploy",
                CreateDeploymentResponseSource.Cli => "cli",
                CreateDeploymentResponseSource.CloneRepo => "clone/repo",
                CreateDeploymentResponseSource.Git => "git",
                CreateDeploymentResponseSource.Import => "import",
                CreateDeploymentResponseSource.ImportRepo => "import/repo",
                CreateDeploymentResponseSource.Redeploy => "redeploy",
                CreateDeploymentResponseSource.V0Web => "v0-web",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseSource? ToEnum(string value)
        {
            return value switch
            {
                "api-trigger-git-deploy" => CreateDeploymentResponseSource.ApiTriggerGitDeploy,
                "cli" => CreateDeploymentResponseSource.Cli,
                "clone/repo" => CreateDeploymentResponseSource.CloneRepo,
                "git" => CreateDeploymentResponseSource.Git,
                "import" => CreateDeploymentResponseSource.Import,
                "import/repo" => CreateDeploymentResponseSource.ImportRepo,
                "redeploy" => CreateDeploymentResponseSource.Redeploy,
                "v0-web" => CreateDeploymentResponseSource.V0Web,
                _ => null,
            };
        }
    }
}