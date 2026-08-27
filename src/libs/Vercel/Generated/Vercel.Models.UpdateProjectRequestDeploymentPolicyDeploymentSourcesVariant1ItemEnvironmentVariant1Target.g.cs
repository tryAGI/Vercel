
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateProjectRequestDeploymentPolicyDeploymentSourcesVariant1ItemEnvironmentVariant1Target
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
    public static class UpdateProjectRequestDeploymentPolicyDeploymentSourcesVariant1ItemEnvironmentVariant1TargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectRequestDeploymentPolicyDeploymentSourcesVariant1ItemEnvironmentVariant1Target value)
        {
            return value switch
            {
                UpdateProjectRequestDeploymentPolicyDeploymentSourcesVariant1ItemEnvironmentVariant1Target.Preview => "preview",
                UpdateProjectRequestDeploymentPolicyDeploymentSourcesVariant1ItemEnvironmentVariant1Target.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectRequestDeploymentPolicyDeploymentSourcesVariant1ItemEnvironmentVariant1Target? ToEnum(string value)
        {
            return value switch
            {
                "preview" => UpdateProjectRequestDeploymentPolicyDeploymentSourcesVariant1ItemEnvironmentVariant1Target.Preview,
                "production" => UpdateProjectRequestDeploymentPolicyDeploymentSourcesVariant1ItemEnvironmentVariant1Target.Production,
                _ => null,
            };
        }
    }
}