
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectResponseDeploymentPolicyDeploymentSourceEnvironmentVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectResponseDeploymentPolicyDeploymentSourceEnvironmentVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseDeploymentPolicyDeploymentSourceEnvironmentVariant1Type value)
        {
            return value switch
            {
                GetProjectResponseDeploymentPolicyDeploymentSourceEnvironmentVariant1Type.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseDeploymentPolicyDeploymentSourceEnvironmentVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "system" => GetProjectResponseDeploymentPolicyDeploymentSourceEnvironmentVariant1Type.System,
                _ => null,
            };
        }
    }
}