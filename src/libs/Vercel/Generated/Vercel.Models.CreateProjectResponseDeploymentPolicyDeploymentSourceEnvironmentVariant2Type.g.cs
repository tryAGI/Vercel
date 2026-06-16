
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectResponseDeploymentPolicyDeploymentSourceEnvironmentVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Custom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectResponseDeploymentPolicyDeploymentSourceEnvironmentVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseDeploymentPolicyDeploymentSourceEnvironmentVariant2Type value)
        {
            return value switch
            {
                CreateProjectResponseDeploymentPolicyDeploymentSourceEnvironmentVariant2Type.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseDeploymentPolicyDeploymentSourceEnvironmentVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "custom" => CreateProjectResponseDeploymentPolicyDeploymentSourceEnvironmentVariant2Type.Custom,
                _ => null,
            };
        }
    }
}