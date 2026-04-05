
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The source of the deployment.<br/>
    /// Example: cli
    /// </summary>
    public enum GetDeploymentsResponseDeploymentSource
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
    public static class GetDeploymentsResponseDeploymentSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentsResponseDeploymentSource value)
        {
            return value switch
            {
                GetDeploymentsResponseDeploymentSource.ApiTriggerGitDeploy => "api-trigger-git-deploy",
                GetDeploymentsResponseDeploymentSource.Cli => "cli",
                GetDeploymentsResponseDeploymentSource.CloneRepo => "clone/repo",
                GetDeploymentsResponseDeploymentSource.Git => "git",
                GetDeploymentsResponseDeploymentSource.Import => "import",
                GetDeploymentsResponseDeploymentSource.ImportRepo => "import/repo",
                GetDeploymentsResponseDeploymentSource.Redeploy => "redeploy",
                GetDeploymentsResponseDeploymentSource.V0Web => "v0-web",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentsResponseDeploymentSource? ToEnum(string value)
        {
            return value switch
            {
                "api-trigger-git-deploy" => GetDeploymentsResponseDeploymentSource.ApiTriggerGitDeploy,
                "cli" => GetDeploymentsResponseDeploymentSource.Cli,
                "clone/repo" => GetDeploymentsResponseDeploymentSource.CloneRepo,
                "git" => GetDeploymentsResponseDeploymentSource.Git,
                "import" => GetDeploymentsResponseDeploymentSource.Import,
                "import/repo" => GetDeploymentsResponseDeploymentSource.ImportRepo,
                "redeploy" => GetDeploymentsResponseDeploymentSource.Redeploy,
                "v0-web" => GetDeploymentsResponseDeploymentSource.V0Web,
                _ => null,
            };
        }
    }
}