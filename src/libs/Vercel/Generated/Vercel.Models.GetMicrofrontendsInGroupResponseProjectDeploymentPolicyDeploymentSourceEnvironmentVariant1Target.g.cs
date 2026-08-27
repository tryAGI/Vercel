
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectDeploymentPolicyDeploymentSourceEnvironmentVariant1Target
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
    public static class GetMicrofrontendsInGroupResponseProjectDeploymentPolicyDeploymentSourceEnvironmentVariant1TargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectDeploymentPolicyDeploymentSourceEnvironmentVariant1Target value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectDeploymentPolicyDeploymentSourceEnvironmentVariant1Target.Preview => "preview",
                GetMicrofrontendsInGroupResponseProjectDeploymentPolicyDeploymentSourceEnvironmentVariant1Target.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectDeploymentPolicyDeploymentSourceEnvironmentVariant1Target? ToEnum(string value)
        {
            return value switch
            {
                "preview" => GetMicrofrontendsInGroupResponseProjectDeploymentPolicyDeploymentSourceEnvironmentVariant1Target.Preview,
                "production" => GetMicrofrontendsInGroupResponseProjectDeploymentPolicyDeploymentSourceEnvironmentVariant1Target.Production,
                _ => null,
            };
        }
    }
}