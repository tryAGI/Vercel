
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared383028c008cc4ae0DisabledReason
    {
        /// <summary>
        ///
        /// </summary>
        AccountPlanDowngrade,
        /// <summary>
        ///
        /// </summary>
        DisabledByAdmin,
        /// <summary>
        ///
        /// </summary>
        DisabledByOwner,
        /// <summary>
        ///
        /// </summary>
        FeatureNotAvailable,
        /// <summary>
        ///
        /// </summary>
        LimitsExceeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared383028c008cc4ae0DisabledReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared383028c008cc4ae0DisabledReason value)
        {
            return value switch
            {
                AutoSDKShared383028c008cc4ae0DisabledReason.AccountPlanDowngrade => "account-plan-downgrade",
                AutoSDKShared383028c008cc4ae0DisabledReason.DisabledByAdmin => "disabled-by-admin",
                AutoSDKShared383028c008cc4ae0DisabledReason.DisabledByOwner => "disabled-by-owner",
                AutoSDKShared383028c008cc4ae0DisabledReason.FeatureNotAvailable => "feature-not-available",
                AutoSDKShared383028c008cc4ae0DisabledReason.LimitsExceeded => "limits-exceeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared383028c008cc4ae0DisabledReason? ToEnum(string value)
        {
            return value switch
            {
                "account-plan-downgrade" => AutoSDKShared383028c008cc4ae0DisabledReason.AccountPlanDowngrade,
                "disabled-by-admin" => AutoSDKShared383028c008cc4ae0DisabledReason.DisabledByAdmin,
                "disabled-by-owner" => AutoSDKShared383028c008cc4ae0DisabledReason.DisabledByOwner,
                "feature-not-available" => AutoSDKShared383028c008cc4ae0DisabledReason.FeatureNotAvailable,
                "limits-exceeded" => AutoSDKShared383028c008cc4ae0DisabledReason.LimitsExceeded,
                _ => null,
            };
        }
    }
}