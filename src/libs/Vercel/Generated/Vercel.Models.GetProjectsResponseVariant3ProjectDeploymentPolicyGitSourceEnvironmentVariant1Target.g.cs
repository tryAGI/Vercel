
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectDeploymentPolicyGitSourceEnvironmentVariant1Target
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
    public static class GetProjectsResponseVariant3ProjectDeploymentPolicyGitSourceEnvironmentVariant1TargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectDeploymentPolicyGitSourceEnvironmentVariant1Target value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectDeploymentPolicyGitSourceEnvironmentVariant1Target.Preview => "preview",
                GetProjectsResponseVariant3ProjectDeploymentPolicyGitSourceEnvironmentVariant1Target.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectDeploymentPolicyGitSourceEnvironmentVariant1Target? ToEnum(string value)
        {
            return value switch
            {
                "preview" => GetProjectsResponseVariant3ProjectDeploymentPolicyGitSourceEnvironmentVariant1Target.Preview,
                "production" => GetProjectsResponseVariant3ProjectDeploymentPolicyGitSourceEnvironmentVariant1Target.Production,
                _ => null,
            };
        }
    }
}