
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectResponseDeploymentPolicyDeploymentSourceEnvironmentVariant1Target
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
    public static class CreateProjectResponseDeploymentPolicyDeploymentSourceEnvironmentVariant1TargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseDeploymentPolicyDeploymentSourceEnvironmentVariant1Target value)
        {
            return value switch
            {
                CreateProjectResponseDeploymentPolicyDeploymentSourceEnvironmentVariant1Target.Preview => "preview",
                CreateProjectResponseDeploymentPolicyDeploymentSourceEnvironmentVariant1Target.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseDeploymentPolicyDeploymentSourceEnvironmentVariant1Target? ToEnum(string value)
        {
            return value switch
            {
                "preview" => CreateProjectResponseDeploymentPolicyDeploymentSourceEnvironmentVariant1Target.Preview,
                "production" => CreateProjectResponseDeploymentPolicyDeploymentSourceEnvironmentVariant1Target.Production,
                _ => null,
            };
        }
    }
}