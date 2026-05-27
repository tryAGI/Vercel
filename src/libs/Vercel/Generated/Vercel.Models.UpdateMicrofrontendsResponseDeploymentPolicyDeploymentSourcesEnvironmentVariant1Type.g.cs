
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateMicrofrontendsResponseDeploymentPolicyDeploymentSourcesEnvironmentVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateMicrofrontendsResponseDeploymentPolicyDeploymentSourcesEnvironmentVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseDeploymentPolicyDeploymentSourcesEnvironmentVariant1Type value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseDeploymentPolicyDeploymentSourcesEnvironmentVariant1Type.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseDeploymentPolicyDeploymentSourcesEnvironmentVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "system" => UpdateMicrofrontendsResponseDeploymentPolicyDeploymentSourcesEnvironmentVariant1Type.System,
                _ => null,
            };
        }
    }
}