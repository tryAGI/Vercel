
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectResponseDeploymentPolicyDeploymentSourcesEnvironmentVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectResponseDeploymentPolicyDeploymentSourcesEnvironmentVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseDeploymentPolicyDeploymentSourcesEnvironmentVariant1Type value)
        {
            return value switch
            {
                GetProjectResponseDeploymentPolicyDeploymentSourcesEnvironmentVariant1Type.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseDeploymentPolicyDeploymentSourcesEnvironmentVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "system" => GetProjectResponseDeploymentPolicyDeploymentSourcesEnvironmentVariant1Type.System,
                _ => null,
            };
        }
    }
}