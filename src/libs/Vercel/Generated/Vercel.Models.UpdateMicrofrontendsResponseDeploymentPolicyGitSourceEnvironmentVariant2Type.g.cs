
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateMicrofrontendsResponseDeploymentPolicyGitSourceEnvironmentVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        Custom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateMicrofrontendsResponseDeploymentPolicyGitSourceEnvironmentVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseDeploymentPolicyGitSourceEnvironmentVariant2Type value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseDeploymentPolicyGitSourceEnvironmentVariant2Type.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseDeploymentPolicyGitSourceEnvironmentVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "custom" => UpdateMicrofrontendsResponseDeploymentPolicyGitSourceEnvironmentVariant2Type.Custom,
                _ => null,
            };
        }
    }
}