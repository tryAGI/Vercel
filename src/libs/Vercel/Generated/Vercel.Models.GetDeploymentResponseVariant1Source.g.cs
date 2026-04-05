
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Where was the deployment created from<br/>
    /// Example: cli
    /// </summary>
    public enum GetDeploymentResponseVariant1Source
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
    public static class GetDeploymentResponseVariant1SourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant1Source value)
        {
            return value switch
            {
                GetDeploymentResponseVariant1Source.ApiTriggerGitDeploy => "api-trigger-git-deploy",
                GetDeploymentResponseVariant1Source.Cli => "cli",
                GetDeploymentResponseVariant1Source.CloneRepo => "clone/repo",
                GetDeploymentResponseVariant1Source.Git => "git",
                GetDeploymentResponseVariant1Source.Import => "import",
                GetDeploymentResponseVariant1Source.ImportRepo => "import/repo",
                GetDeploymentResponseVariant1Source.Redeploy => "redeploy",
                GetDeploymentResponseVariant1Source.V0Web => "v0-web",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant1Source? ToEnum(string value)
        {
            return value switch
            {
                "api-trigger-git-deploy" => GetDeploymentResponseVariant1Source.ApiTriggerGitDeploy,
                "cli" => GetDeploymentResponseVariant1Source.Cli,
                "clone/repo" => GetDeploymentResponseVariant1Source.CloneRepo,
                "git" => GetDeploymentResponseVariant1Source.Git,
                "import" => GetDeploymentResponseVariant1Source.Import,
                "import/repo" => GetDeploymentResponseVariant1Source.ImportRepo,
                "redeploy" => GetDeploymentResponseVariant1Source.Redeploy,
                "v0-web" => GetDeploymentResponseVariant1Source.V0Web,
                _ => null,
            };
        }
    }
}