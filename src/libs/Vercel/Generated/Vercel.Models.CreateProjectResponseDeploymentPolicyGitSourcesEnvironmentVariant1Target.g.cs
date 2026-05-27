
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectResponseDeploymentPolicyGitSourcesEnvironmentVariant1Target
    {
        /// <summary>
        /// 
        /// </summary>
        Preview,
        /// <summary>
        /// 
        /// </summary>
        Production,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectResponseDeploymentPolicyGitSourcesEnvironmentVariant1TargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseDeploymentPolicyGitSourcesEnvironmentVariant1Target value)
        {
            return value switch
            {
                CreateProjectResponseDeploymentPolicyGitSourcesEnvironmentVariant1Target.Preview => "preview",
                CreateProjectResponseDeploymentPolicyGitSourcesEnvironmentVariant1Target.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseDeploymentPolicyGitSourcesEnvironmentVariant1Target? ToEnum(string value)
        {
            return value switch
            {
                "preview" => CreateProjectResponseDeploymentPolicyGitSourcesEnvironmentVariant1Target.Preview,
                "production" => CreateProjectResponseDeploymentPolicyGitSourcesEnvironmentVariant1Target.Production,
                _ => null,
            };
        }
    }
}