
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectResponseDeploymentPolicyDeploymentSourcesEnvironmentVariant1Target
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
    public static class GetProjectResponseDeploymentPolicyDeploymentSourcesEnvironmentVariant1TargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseDeploymentPolicyDeploymentSourcesEnvironmentVariant1Target value)
        {
            return value switch
            {
                GetProjectResponseDeploymentPolicyDeploymentSourcesEnvironmentVariant1Target.Preview => "preview",
                GetProjectResponseDeploymentPolicyDeploymentSourcesEnvironmentVariant1Target.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseDeploymentPolicyDeploymentSourcesEnvironmentVariant1Target? ToEnum(string value)
        {
            return value switch
            {
                "preview" => GetProjectResponseDeploymentPolicyDeploymentSourcesEnvironmentVariant1Target.Preview,
                "production" => GetProjectResponseDeploymentPolicyDeploymentSourcesEnvironmentVariant1Target.Production,
                _ => null,
            };
        }
    }
}