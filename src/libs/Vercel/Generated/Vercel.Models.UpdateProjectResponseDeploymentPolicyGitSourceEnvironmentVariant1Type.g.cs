
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateProjectResponseDeploymentPolicyGitSourceEnvironmentVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateProjectResponseDeploymentPolicyGitSourceEnvironmentVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseDeploymentPolicyGitSourceEnvironmentVariant1Type value)
        {
            return value switch
            {
                UpdateProjectResponseDeploymentPolicyGitSourceEnvironmentVariant1Type.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseDeploymentPolicyGitSourceEnvironmentVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "system" => UpdateProjectResponseDeploymentPolicyGitSourceEnvironmentVariant1Type.System,
                _ => null,
            };
        }
    }
}