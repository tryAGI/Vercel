
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Where was the deployment created from. Best-effort guess for metrics only — not authoritative; do not gate behavior on it.<br/>
    /// Example: cli
    /// </summary>
    public enum CreateDeploymentResponseVariant2Source
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
        GitDeployHook,
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
    public static class CreateDeploymentResponseVariant2SourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseVariant2Source value)
        {
            return value switch
            {
                CreateDeploymentResponseVariant2Source.ApiTriggerGitDeploy => "api-trigger-git-deploy",
                CreateDeploymentResponseVariant2Source.Cli => "cli",
                CreateDeploymentResponseVariant2Source.CloneRepo => "clone/repo",
                CreateDeploymentResponseVariant2Source.Drop => "drop",
                CreateDeploymentResponseVariant2Source.Git => "git",
                CreateDeploymentResponseVariant2Source.GitDeployHook => "git-deploy-hook",
                CreateDeploymentResponseVariant2Source.Import => "import",
                CreateDeploymentResponseVariant2Source.ImportRepo => "import/repo",
                CreateDeploymentResponseVariant2Source.Redeploy => "redeploy",
                CreateDeploymentResponseVariant2Source.V0Web => "v0-web",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseVariant2Source? ToEnum(string value)
        {
            return value switch
            {
                "api-trigger-git-deploy" => CreateDeploymentResponseVariant2Source.ApiTriggerGitDeploy,
                "cli" => CreateDeploymentResponseVariant2Source.Cli,
                "clone/repo" => CreateDeploymentResponseVariant2Source.CloneRepo,
                "drop" => CreateDeploymentResponseVariant2Source.Drop,
                "git" => CreateDeploymentResponseVariant2Source.Git,
                "git-deploy-hook" => CreateDeploymentResponseVariant2Source.GitDeployHook,
                "import" => CreateDeploymentResponseVariant2Source.Import,
                "import/repo" => CreateDeploymentResponseVariant2Source.ImportRepo,
                "redeploy" => CreateDeploymentResponseVariant2Source.Redeploy,
                "v0-web" => CreateDeploymentResponseVariant2Source.V0Web,
                _ => null,
            };
        }
    }
}