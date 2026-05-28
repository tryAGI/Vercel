
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum TeamDeploymentPolicyDeploymentSourceEnvironmentVariant1Target
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
    public static class TeamDeploymentPolicyDeploymentSourceEnvironmentVariant1TargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamDeploymentPolicyDeploymentSourceEnvironmentVariant1Target value)
        {
            return value switch
            {
                TeamDeploymentPolicyDeploymentSourceEnvironmentVariant1Target.Preview => "preview",
                TeamDeploymentPolicyDeploymentSourceEnvironmentVariant1Target.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamDeploymentPolicyDeploymentSourceEnvironmentVariant1Target? ToEnum(string value)
        {
            return value switch
            {
                "preview" => TeamDeploymentPolicyDeploymentSourceEnvironmentVariant1Target.Preview,
                "production" => TeamDeploymentPolicyDeploymentSourceEnvironmentVariant1Target.Production,
                _ => null,
            };
        }
    }
}