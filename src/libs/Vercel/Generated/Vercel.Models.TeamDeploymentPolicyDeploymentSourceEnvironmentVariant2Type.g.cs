
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum TeamDeploymentPolicyDeploymentSourceEnvironmentVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Custom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TeamDeploymentPolicyDeploymentSourceEnvironmentVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamDeploymentPolicyDeploymentSourceEnvironmentVariant2Type value)
        {
            return value switch
            {
                TeamDeploymentPolicyDeploymentSourceEnvironmentVariant2Type.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamDeploymentPolicyDeploymentSourceEnvironmentVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "custom" => TeamDeploymentPolicyDeploymentSourceEnvironmentVariant2Type.Custom,
                _ => null,
            };
        }
    }
}