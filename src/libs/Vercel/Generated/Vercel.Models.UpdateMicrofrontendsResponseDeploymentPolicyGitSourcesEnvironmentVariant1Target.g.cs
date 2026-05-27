
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateMicrofrontendsResponseDeploymentPolicyGitSourcesEnvironmentVariant1Target
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
    public static class UpdateMicrofrontendsResponseDeploymentPolicyGitSourcesEnvironmentVariant1TargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseDeploymentPolicyGitSourcesEnvironmentVariant1Target value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseDeploymentPolicyGitSourcesEnvironmentVariant1Target.Preview => "preview",
                UpdateMicrofrontendsResponseDeploymentPolicyGitSourcesEnvironmentVariant1Target.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseDeploymentPolicyGitSourcesEnvironmentVariant1Target? ToEnum(string value)
        {
            return value switch
            {
                "preview" => UpdateMicrofrontendsResponseDeploymentPolicyGitSourcesEnvironmentVariant1Target.Preview,
                "production" => UpdateMicrofrontendsResponseDeploymentPolicyGitSourcesEnvironmentVariant1Target.Production,
                _ => null,
            };
        }
    }
}