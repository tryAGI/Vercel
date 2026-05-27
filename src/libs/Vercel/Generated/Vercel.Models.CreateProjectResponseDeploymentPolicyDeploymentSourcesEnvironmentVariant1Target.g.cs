
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectResponseDeploymentPolicyDeploymentSourcesEnvironmentVariant1Target
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
    public static class CreateProjectResponseDeploymentPolicyDeploymentSourcesEnvironmentVariant1TargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseDeploymentPolicyDeploymentSourcesEnvironmentVariant1Target value)
        {
            return value switch
            {
                CreateProjectResponseDeploymentPolicyDeploymentSourcesEnvironmentVariant1Target.Preview => "preview",
                CreateProjectResponseDeploymentPolicyDeploymentSourcesEnvironmentVariant1Target.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseDeploymentPolicyDeploymentSourcesEnvironmentVariant1Target? ToEnum(string value)
        {
            return value switch
            {
                "preview" => CreateProjectResponseDeploymentPolicyDeploymentSourcesEnvironmentVariant1Target.Preview,
                "production" => CreateProjectResponseDeploymentPolicyDeploymentSourcesEnvironmentVariant1Target.Production,
                _ => null,
            };
        }
    }
}