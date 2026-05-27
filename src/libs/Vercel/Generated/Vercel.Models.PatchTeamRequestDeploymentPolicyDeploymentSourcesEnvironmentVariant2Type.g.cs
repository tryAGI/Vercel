
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchTeamRequestDeploymentPolicyDeploymentSourcesEnvironmentVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Custom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchTeamRequestDeploymentPolicyDeploymentSourcesEnvironmentVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchTeamRequestDeploymentPolicyDeploymentSourcesEnvironmentVariant2Type value)
        {
            return value switch
            {
                PatchTeamRequestDeploymentPolicyDeploymentSourcesEnvironmentVariant2Type.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchTeamRequestDeploymentPolicyDeploymentSourcesEnvironmentVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "custom" => PatchTeamRequestDeploymentPolicyDeploymentSourcesEnvironmentVariant2Type.Custom,
                _ => null,
            };
        }
    }
}