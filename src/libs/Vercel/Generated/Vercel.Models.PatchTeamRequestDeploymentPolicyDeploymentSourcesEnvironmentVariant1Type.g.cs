
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchTeamRequestDeploymentPolicyDeploymentSourcesEnvironmentVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchTeamRequestDeploymentPolicyDeploymentSourcesEnvironmentVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchTeamRequestDeploymentPolicyDeploymentSourcesEnvironmentVariant1Type value)
        {
            return value switch
            {
                PatchTeamRequestDeploymentPolicyDeploymentSourcesEnvironmentVariant1Type.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchTeamRequestDeploymentPolicyDeploymentSourcesEnvironmentVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "system" => PatchTeamRequestDeploymentPolicyDeploymentSourcesEnvironmentVariant1Type.System,
                _ => null,
            };
        }
    }
}