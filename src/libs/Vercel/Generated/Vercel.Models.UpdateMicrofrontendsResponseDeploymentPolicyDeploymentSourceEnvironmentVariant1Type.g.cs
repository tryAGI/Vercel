
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateMicrofrontendsResponseDeploymentPolicyDeploymentSourceEnvironmentVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateMicrofrontendsResponseDeploymentPolicyDeploymentSourceEnvironmentVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseDeploymentPolicyDeploymentSourceEnvironmentVariant1Type value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseDeploymentPolicyDeploymentSourceEnvironmentVariant1Type.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseDeploymentPolicyDeploymentSourceEnvironmentVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "system" => UpdateMicrofrontendsResponseDeploymentPolicyDeploymentSourceEnvironmentVariant1Type.System,
                _ => null,
            };
        }
    }
}