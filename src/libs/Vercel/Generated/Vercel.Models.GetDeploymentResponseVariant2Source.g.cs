
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Where was the deployment created from<br/>
    /// Example: cli
    /// </summary>
    public enum GetDeploymentResponseVariant2Source
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
    public static class GetDeploymentResponseVariant2SourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant2Source value)
        {
            return value switch
            {
                GetDeploymentResponseVariant2Source.ApiTriggerGitDeploy => "api-trigger-git-deploy",
                GetDeploymentResponseVariant2Source.Cli => "cli",
                GetDeploymentResponseVariant2Source.CloneRepo => "clone/repo",
                GetDeploymentResponseVariant2Source.Git => "git",
                GetDeploymentResponseVariant2Source.Import => "import",
                GetDeploymentResponseVariant2Source.ImportRepo => "import/repo",
                GetDeploymentResponseVariant2Source.Redeploy => "redeploy",
                GetDeploymentResponseVariant2Source.V0Web => "v0-web",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant2Source? ToEnum(string value)
        {
            return value switch
            {
                "api-trigger-git-deploy" => GetDeploymentResponseVariant2Source.ApiTriggerGitDeploy,
                "cli" => GetDeploymentResponseVariant2Source.Cli,
                "clone/repo" => GetDeploymentResponseVariant2Source.CloneRepo,
                "git" => GetDeploymentResponseVariant2Source.Git,
                "import" => GetDeploymentResponseVariant2Source.Import,
                "import/repo" => GetDeploymentResponseVariant2Source.ImportRepo,
                "redeploy" => GetDeploymentResponseVariant2Source.Redeploy,
                "v0-web" => GetDeploymentResponseVariant2Source.V0Web,
                _ => null,
            };
        }
    }
}