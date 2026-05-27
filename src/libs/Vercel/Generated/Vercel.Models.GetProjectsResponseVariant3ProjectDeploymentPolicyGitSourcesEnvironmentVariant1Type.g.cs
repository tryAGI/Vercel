
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectDeploymentPolicyGitSourcesEnvironmentVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant3ProjectDeploymentPolicyGitSourcesEnvironmentVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectDeploymentPolicyGitSourcesEnvironmentVariant1Type value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectDeploymentPolicyGitSourcesEnvironmentVariant1Type.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectDeploymentPolicyGitSourcesEnvironmentVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "system" => GetProjectsResponseVariant3ProjectDeploymentPolicyGitSourcesEnvironmentVariant1Type.System,
                _ => null,
            };
        }
    }
}