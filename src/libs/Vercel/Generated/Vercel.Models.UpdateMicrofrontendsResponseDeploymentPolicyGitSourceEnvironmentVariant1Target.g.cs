
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateMicrofrontendsResponseDeploymentPolicyGitSourceEnvironmentVariant1Target
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
    public static class UpdateMicrofrontendsResponseDeploymentPolicyGitSourceEnvironmentVariant1TargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseDeploymentPolicyGitSourceEnvironmentVariant1Target value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseDeploymentPolicyGitSourceEnvironmentVariant1Target.Preview => "preview",
                UpdateMicrofrontendsResponseDeploymentPolicyGitSourceEnvironmentVariant1Target.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseDeploymentPolicyGitSourceEnvironmentVariant1Target? ToEnum(string value)
        {
            return value switch
            {
                "preview" => UpdateMicrofrontendsResponseDeploymentPolicyGitSourceEnvironmentVariant1Target.Preview,
                "production" => UpdateMicrofrontendsResponseDeploymentPolicyGitSourceEnvironmentVariant1Target.Production,
                _ => null,
            };
        }
    }
}