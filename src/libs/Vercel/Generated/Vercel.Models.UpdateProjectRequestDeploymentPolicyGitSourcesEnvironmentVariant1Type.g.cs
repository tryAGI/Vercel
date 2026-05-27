
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectRequestDeploymentPolicyGitSourcesEnvironmentVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateProjectRequestDeploymentPolicyGitSourcesEnvironmentVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectRequestDeploymentPolicyGitSourcesEnvironmentVariant1Type value)
        {
            return value switch
            {
                UpdateProjectRequestDeploymentPolicyGitSourcesEnvironmentVariant1Type.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectRequestDeploymentPolicyGitSourcesEnvironmentVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "system" => UpdateProjectRequestDeploymentPolicyGitSourcesEnvironmentVariant1Type.System,
                _ => null,
            };
        }
    }
}