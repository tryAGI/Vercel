
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectDeploymentPolicyGitSourcesEnvironmentVariant1Target
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
    public static class GetProjectsResponseVariant3ProjectDeploymentPolicyGitSourcesEnvironmentVariant1TargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectDeploymentPolicyGitSourcesEnvironmentVariant1Target value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectDeploymentPolicyGitSourcesEnvironmentVariant1Target.Preview => "preview",
                GetProjectsResponseVariant3ProjectDeploymentPolicyGitSourcesEnvironmentVariant1Target.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectDeploymentPolicyGitSourcesEnvironmentVariant1Target? ToEnum(string value)
        {
            return value switch
            {
                "preview" => GetProjectsResponseVariant3ProjectDeploymentPolicyGitSourcesEnvironmentVariant1Target.Preview,
                "production" => GetProjectsResponseVariant3ProjectDeploymentPolicyGitSourcesEnvironmentVariant1Target.Production,
                _ => null,
            };
        }
    }
}