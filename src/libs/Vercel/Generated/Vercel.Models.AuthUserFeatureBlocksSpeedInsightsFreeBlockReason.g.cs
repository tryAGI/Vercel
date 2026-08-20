
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum AuthUserFeatureBlocksSpeedInsightsFreeBlockReason
    {
        /// <summary>
        /// 
        /// </summary>
        AdminOverride,
        /// <summary>
        /// 
        /// </summary>
        HardBlocked,
        /// <summary>
        /// 
        /// </summary>
        LimitsExceeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuthUserFeatureBlocksSpeedInsightsFreeBlockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthUserFeatureBlocksSpeedInsightsFreeBlockReason value)
        {
            return value switch
            {
                AuthUserFeatureBlocksSpeedInsightsFreeBlockReason.AdminOverride => "admin_override",
                AuthUserFeatureBlocksSpeedInsightsFreeBlockReason.HardBlocked => "hard_blocked",
                AuthUserFeatureBlocksSpeedInsightsFreeBlockReason.LimitsExceeded => "limits_exceeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthUserFeatureBlocksSpeedInsightsFreeBlockReason? ToEnum(string value)
        {
            return value switch
            {
                "admin_override" => AuthUserFeatureBlocksSpeedInsightsFreeBlockReason.AdminOverride,
                "hard_blocked" => AuthUserFeatureBlocksSpeedInsightsFreeBlockReason.HardBlocked,
                "limits_exceeded" => AuthUserFeatureBlocksSpeedInsightsFreeBlockReason.LimitsExceeded,
                _ => null,
            };
        }
    }
}