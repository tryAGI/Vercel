
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectRequestDeploymentPolicyDeploymentSourcesEnvironmentVariant1Target
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
    public static class UpdateProjectRequestDeploymentPolicyDeploymentSourcesEnvironmentVariant1TargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectRequestDeploymentPolicyDeploymentSourcesEnvironmentVariant1Target value)
        {
            return value switch
            {
                UpdateProjectRequestDeploymentPolicyDeploymentSourcesEnvironmentVariant1Target.Preview => "preview",
                UpdateProjectRequestDeploymentPolicyDeploymentSourcesEnvironmentVariant1Target.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectRequestDeploymentPolicyDeploymentSourcesEnvironmentVariant1Target? ToEnum(string value)
        {
            return value switch
            {
                "preview" => UpdateProjectRequestDeploymentPolicyDeploymentSourcesEnvironmentVariant1Target.Preview,
                "production" => UpdateProjectRequestDeploymentPolicyDeploymentSourcesEnvironmentVariant1Target.Production,
                _ => null,
            };
        }
    }
}