
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponseDeploymentPolicyDeploymentSourcesEnvironmentVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateProjectResponseDeploymentPolicyDeploymentSourcesEnvironmentVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseDeploymentPolicyDeploymentSourcesEnvironmentVariant1Type value)
        {
            return value switch
            {
                UpdateProjectResponseDeploymentPolicyDeploymentSourcesEnvironmentVariant1Type.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseDeploymentPolicyDeploymentSourcesEnvironmentVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "system" => UpdateProjectResponseDeploymentPolicyDeploymentSourcesEnvironmentVariant1Type.System,
                _ => null,
            };
        }
    }
}