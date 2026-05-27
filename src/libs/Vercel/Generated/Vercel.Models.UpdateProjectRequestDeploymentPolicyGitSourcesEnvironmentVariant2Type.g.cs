
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectRequestDeploymentPolicyGitSourcesEnvironmentVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Custom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateProjectRequestDeploymentPolicyGitSourcesEnvironmentVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectRequestDeploymentPolicyGitSourcesEnvironmentVariant2Type value)
        {
            return value switch
            {
                UpdateProjectRequestDeploymentPolicyGitSourcesEnvironmentVariant2Type.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectRequestDeploymentPolicyGitSourcesEnvironmentVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "custom" => UpdateProjectRequestDeploymentPolicyGitSourcesEnvironmentVariant2Type.Custom,
                _ => null,
            };
        }
    }
}