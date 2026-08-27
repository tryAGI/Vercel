
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectResponseDeploymentPolicyGitSourceEnvironmentVariant1Target
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
    public static class GetProjectResponseDeploymentPolicyGitSourceEnvironmentVariant1TargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseDeploymentPolicyGitSourceEnvironmentVariant1Target value)
        {
            return value switch
            {
                GetProjectResponseDeploymentPolicyGitSourceEnvironmentVariant1Target.Preview => "preview",
                GetProjectResponseDeploymentPolicyGitSourceEnvironmentVariant1Target.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseDeploymentPolicyGitSourceEnvironmentVariant1Target? ToEnum(string value)
        {
            return value switch
            {
                "preview" => GetProjectResponseDeploymentPolicyGitSourceEnvironmentVariant1Target.Preview,
                "production" => GetProjectResponseDeploymentPolicyGitSourceEnvironmentVariant1Target.Production,
                _ => null,
            };
        }
    }
}