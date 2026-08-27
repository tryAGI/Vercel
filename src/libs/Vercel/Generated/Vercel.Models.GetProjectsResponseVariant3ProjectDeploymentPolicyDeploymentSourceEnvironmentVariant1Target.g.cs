
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectDeploymentPolicyDeploymentSourceEnvironmentVariant1Target
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
    public static class GetProjectsResponseVariant3ProjectDeploymentPolicyDeploymentSourceEnvironmentVariant1TargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectDeploymentPolicyDeploymentSourceEnvironmentVariant1Target value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectDeploymentPolicyDeploymentSourceEnvironmentVariant1Target.Preview => "preview",
                GetProjectsResponseVariant3ProjectDeploymentPolicyDeploymentSourceEnvironmentVariant1Target.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectDeploymentPolicyDeploymentSourceEnvironmentVariant1Target? ToEnum(string value)
        {
            return value switch
            {
                "preview" => GetProjectsResponseVariant3ProjectDeploymentPolicyDeploymentSourceEnvironmentVariant1Target.Preview,
                "production" => GetProjectsResponseVariant3ProjectDeploymentPolicyDeploymentSourceEnvironmentVariant1Target.Production,
                _ => null,
            };
        }
    }
}