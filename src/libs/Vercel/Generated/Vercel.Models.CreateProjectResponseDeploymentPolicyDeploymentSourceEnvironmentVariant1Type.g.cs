
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateProjectResponseDeploymentPolicyDeploymentSourceEnvironmentVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectResponseDeploymentPolicyDeploymentSourceEnvironmentVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseDeploymentPolicyDeploymentSourceEnvironmentVariant1Type value)
        {
            return value switch
            {
                CreateProjectResponseDeploymentPolicyDeploymentSourceEnvironmentVariant1Type.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseDeploymentPolicyDeploymentSourceEnvironmentVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "system" => CreateProjectResponseDeploymentPolicyDeploymentSourceEnvironmentVariant1Type.System,
                _ => null,
            };
        }
    }
}