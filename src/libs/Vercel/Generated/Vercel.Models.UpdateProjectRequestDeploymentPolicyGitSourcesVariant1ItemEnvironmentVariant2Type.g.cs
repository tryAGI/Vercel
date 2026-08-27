
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateProjectRequestDeploymentPolicyGitSourcesVariant1ItemEnvironmentVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        Custom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateProjectRequestDeploymentPolicyGitSourcesVariant1ItemEnvironmentVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectRequestDeploymentPolicyGitSourcesVariant1ItemEnvironmentVariant2Type value)
        {
            return value switch
            {
                UpdateProjectRequestDeploymentPolicyGitSourcesVariant1ItemEnvironmentVariant2Type.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectRequestDeploymentPolicyGitSourcesVariant1ItemEnvironmentVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "custom" => UpdateProjectRequestDeploymentPolicyGitSourcesVariant1ItemEnvironmentVariant2Type.Custom,
                _ => null,
            };
        }
    }
}