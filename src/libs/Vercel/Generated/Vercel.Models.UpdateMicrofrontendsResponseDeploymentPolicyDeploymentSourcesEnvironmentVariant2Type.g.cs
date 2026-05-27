
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateMicrofrontendsResponseDeploymentPolicyDeploymentSourcesEnvironmentVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Custom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateMicrofrontendsResponseDeploymentPolicyDeploymentSourcesEnvironmentVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseDeploymentPolicyDeploymentSourcesEnvironmentVariant2Type value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseDeploymentPolicyDeploymentSourcesEnvironmentVariant2Type.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseDeploymentPolicyDeploymentSourcesEnvironmentVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "custom" => UpdateMicrofrontendsResponseDeploymentPolicyDeploymentSourcesEnvironmentVariant2Type.Custom,
                _ => null,
            };
        }
    }
}