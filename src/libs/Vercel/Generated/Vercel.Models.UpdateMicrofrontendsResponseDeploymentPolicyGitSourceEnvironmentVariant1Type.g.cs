
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateMicrofrontendsResponseDeploymentPolicyGitSourceEnvironmentVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateMicrofrontendsResponseDeploymentPolicyGitSourceEnvironmentVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseDeploymentPolicyGitSourceEnvironmentVariant1Type value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseDeploymentPolicyGitSourceEnvironmentVariant1Type.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseDeploymentPolicyGitSourceEnvironmentVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "system" => UpdateMicrofrontendsResponseDeploymentPolicyGitSourceEnvironmentVariant1Type.System,
                _ => null,
            };
        }
    }
}