
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum TeamDeploymentPolicyGitSourcesEnvironmentVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TeamDeploymentPolicyGitSourcesEnvironmentVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamDeploymentPolicyGitSourcesEnvironmentVariant1Type value)
        {
            return value switch
            {
                TeamDeploymentPolicyGitSourcesEnvironmentVariant1Type.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamDeploymentPolicyGitSourcesEnvironmentVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "system" => TeamDeploymentPolicyGitSourcesEnvironmentVariant1Type.System,
                _ => null,
            };
        }
    }
}