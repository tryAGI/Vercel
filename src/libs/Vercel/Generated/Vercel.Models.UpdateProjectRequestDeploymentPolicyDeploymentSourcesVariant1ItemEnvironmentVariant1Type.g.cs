
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateProjectRequestDeploymentPolicyDeploymentSourcesVariant1ItemEnvironmentVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateProjectRequestDeploymentPolicyDeploymentSourcesVariant1ItemEnvironmentVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectRequestDeploymentPolicyDeploymentSourcesVariant1ItemEnvironmentVariant1Type value)
        {
            return value switch
            {
                UpdateProjectRequestDeploymentPolicyDeploymentSourcesVariant1ItemEnvironmentVariant1Type.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectRequestDeploymentPolicyDeploymentSourcesVariant1ItemEnvironmentVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "system" => UpdateProjectRequestDeploymentPolicyDeploymentSourcesVariant1ItemEnvironmentVariant1Type.System,
                _ => null,
            };
        }
    }
}