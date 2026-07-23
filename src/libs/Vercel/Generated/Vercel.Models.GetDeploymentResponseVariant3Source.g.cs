
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Where was the deployment created from. Best-effort guess for metrics only — not authoritative; do not gate behavior on it.<br/>
    /// Example: cli
    /// </summary>
    public enum GetDeploymentResponseVariant3Source
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
        Drop,
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
    public static class GetDeploymentResponseVariant3SourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant3Source value)
        {
            return value switch
            {
                GetDeploymentResponseVariant3Source.ApiTriggerGitDeploy => "api-trigger-git-deploy",
                GetDeploymentResponseVariant3Source.Cli => "cli",
                GetDeploymentResponseVariant3Source.CloneRepo => "clone/repo",
                GetDeploymentResponseVariant3Source.Drop => "drop",
                GetDeploymentResponseVariant3Source.Git => "git",
                GetDeploymentResponseVariant3Source.Import => "import",
                GetDeploymentResponseVariant3Source.ImportRepo => "import/repo",
                GetDeploymentResponseVariant3Source.Redeploy => "redeploy",
                GetDeploymentResponseVariant3Source.V0Web => "v0-web",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant3Source? ToEnum(string value)
        {
            return value switch
            {
                "api-trigger-git-deploy" => GetDeploymentResponseVariant3Source.ApiTriggerGitDeploy,
                "cli" => GetDeploymentResponseVariant3Source.Cli,
                "clone/repo" => GetDeploymentResponseVariant3Source.CloneRepo,
                "drop" => GetDeploymentResponseVariant3Source.Drop,
                "git" => GetDeploymentResponseVariant3Source.Git,
                "import" => GetDeploymentResponseVariant3Source.Import,
                "import/repo" => GetDeploymentResponseVariant3Source.ImportRepo,
                "redeploy" => GetDeploymentResponseVariant3Source.Redeploy,
                "v0-web" => GetDeploymentResponseVariant3Source.V0Web,
                _ => null,
            };
        }
    }
}