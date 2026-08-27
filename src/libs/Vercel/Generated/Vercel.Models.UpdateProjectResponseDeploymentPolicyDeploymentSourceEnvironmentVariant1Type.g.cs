
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateProjectResponseDeploymentPolicyDeploymentSourceEnvironmentVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateProjectResponseDeploymentPolicyDeploymentSourceEnvironmentVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseDeploymentPolicyDeploymentSourceEnvironmentVariant1Type value)
        {
            return value switch
            {
                UpdateProjectResponseDeploymentPolicyDeploymentSourceEnvironmentVariant1Type.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseDeploymentPolicyDeploymentSourceEnvironmentVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "system" => UpdateProjectResponseDeploymentPolicyDeploymentSourceEnvironmentVariant1Type.System,
                _ => null,
            };
        }
    }
}