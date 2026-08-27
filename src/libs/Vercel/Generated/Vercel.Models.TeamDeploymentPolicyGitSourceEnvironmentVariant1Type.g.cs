
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum TeamDeploymentPolicyGitSourceEnvironmentVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TeamDeploymentPolicyGitSourceEnvironmentVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamDeploymentPolicyGitSourceEnvironmentVariant1Type value)
        {
            return value switch
            {
                TeamDeploymentPolicyGitSourceEnvironmentVariant1Type.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamDeploymentPolicyGitSourceEnvironmentVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "system" => TeamDeploymentPolicyGitSourceEnvironmentVariant1Type.System,
                _ => null,
            };
        }
    }
}