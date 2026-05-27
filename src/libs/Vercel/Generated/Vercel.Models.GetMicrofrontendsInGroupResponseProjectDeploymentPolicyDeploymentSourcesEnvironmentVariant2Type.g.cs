
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectDeploymentPolicyDeploymentSourcesEnvironmentVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Custom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetMicrofrontendsInGroupResponseProjectDeploymentPolicyDeploymentSourcesEnvironmentVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectDeploymentPolicyDeploymentSourcesEnvironmentVariant2Type value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectDeploymentPolicyDeploymentSourcesEnvironmentVariant2Type.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectDeploymentPolicyDeploymentSourcesEnvironmentVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "custom" => GetMicrofrontendsInGroupResponseProjectDeploymentPolicyDeploymentSourcesEnvironmentVariant2Type.Custom,
                _ => null,
            };
        }
    }
}