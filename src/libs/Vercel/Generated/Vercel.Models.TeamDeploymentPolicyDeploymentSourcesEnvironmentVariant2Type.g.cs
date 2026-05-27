
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum TeamDeploymentPolicyDeploymentSourcesEnvironmentVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Custom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TeamDeploymentPolicyDeploymentSourcesEnvironmentVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamDeploymentPolicyDeploymentSourcesEnvironmentVariant2Type value)
        {
            return value switch
            {
                TeamDeploymentPolicyDeploymentSourcesEnvironmentVariant2Type.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamDeploymentPolicyDeploymentSourcesEnvironmentVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "custom" => TeamDeploymentPolicyDeploymentSourcesEnvironmentVariant2Type.Custom,
                _ => null,
            };
        }
    }
}