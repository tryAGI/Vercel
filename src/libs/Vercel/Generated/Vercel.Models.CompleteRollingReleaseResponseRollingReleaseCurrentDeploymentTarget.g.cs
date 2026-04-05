
#nullable enable

namespace Vercel
{
    /// <summary>
    /// If defined, either `staging` if a staging alias in the format `&lt;project&gt;.&lt;team&gt;.now.sh` was assigned upon creation, or `production` if the aliases from `alias` were assigned. `null` value indicates the "preview" deployment.<br/>
    /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
    /// </summary>
    public enum CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentTarget
    {
        /// <summary>
        /// 
        /// </summary>
        Production,
        /// <summary>
        /// 
        /// </summary>
        Staging,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentTarget value)
        {
            return value switch
            {
                CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentTarget.Production => "production",
                CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentTarget.Staging => "staging",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentTarget? ToEnum(string value)
        {
            return value switch
            {
                "production" => CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentTarget.Production,
                "staging" => CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentTarget.Staging,
                _ => null,
            };
        }
    }
}