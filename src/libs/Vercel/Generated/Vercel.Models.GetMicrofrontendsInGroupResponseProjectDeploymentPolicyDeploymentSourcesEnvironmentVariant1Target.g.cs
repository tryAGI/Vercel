
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectDeploymentPolicyDeploymentSourcesEnvironmentVariant1Target
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
    public static class GetMicrofrontendsInGroupResponseProjectDeploymentPolicyDeploymentSourcesEnvironmentVariant1TargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectDeploymentPolicyDeploymentSourcesEnvironmentVariant1Target value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectDeploymentPolicyDeploymentSourcesEnvironmentVariant1Target.Preview => "preview",
                GetMicrofrontendsInGroupResponseProjectDeploymentPolicyDeploymentSourcesEnvironmentVariant1Target.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectDeploymentPolicyDeploymentSourcesEnvironmentVariant1Target? ToEnum(string value)
        {
            return value switch
            {
                "preview" => GetMicrofrontendsInGroupResponseProjectDeploymentPolicyDeploymentSourcesEnvironmentVariant1Target.Preview,
                "production" => GetMicrofrontendsInGroupResponseProjectDeploymentPolicyDeploymentSourcesEnvironmentVariant1Target.Production,
                _ => null,
            };
        }
    }
}