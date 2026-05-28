
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectResponseDeploymentPolicyDeploymentSourceEnvironmentVariant1Target
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
    public static class GetProjectResponseDeploymentPolicyDeploymentSourceEnvironmentVariant1TargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseDeploymentPolicyDeploymentSourceEnvironmentVariant1Target value)
        {
            return value switch
            {
                GetProjectResponseDeploymentPolicyDeploymentSourceEnvironmentVariant1Target.Preview => "preview",
                GetProjectResponseDeploymentPolicyDeploymentSourceEnvironmentVariant1Target.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseDeploymentPolicyDeploymentSourceEnvironmentVariant1Target? ToEnum(string value)
        {
            return value switch
            {
                "preview" => GetProjectResponseDeploymentPolicyDeploymentSourceEnvironmentVariant1Target.Preview,
                "production" => GetProjectResponseDeploymentPolicyDeploymentSourceEnvironmentVariant1Target.Production,
                _ => null,
            };
        }
    }
}