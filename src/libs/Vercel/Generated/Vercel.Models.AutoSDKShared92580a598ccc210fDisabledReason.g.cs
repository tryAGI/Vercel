
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared92580a598ccc210fDisabledReason
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
    public static class AutoSDKShared92580a598ccc210fDisabledReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared92580a598ccc210fDisabledReason value)
        {
            return value switch
            {
                AutoSDKShared92580a598ccc210fDisabledReason.AccountPlanDowngrade => "account-plan-downgrade",
                AutoSDKShared92580a598ccc210fDisabledReason.DisabledByAdmin => "disabled-by-admin",
                AutoSDKShared92580a598ccc210fDisabledReason.DisabledByOwner => "disabled-by-owner",
                AutoSDKShared92580a598ccc210fDisabledReason.FeatureNotAvailable => "feature-not-available",
                AutoSDKShared92580a598ccc210fDisabledReason.LimitsExceeded => "limits-exceeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared92580a598ccc210fDisabledReason? ToEnum(string value)
        {
            return value switch
            {
                "account-plan-downgrade" => AutoSDKShared92580a598ccc210fDisabledReason.AccountPlanDowngrade,
                "disabled-by-admin" => AutoSDKShared92580a598ccc210fDisabledReason.DisabledByAdmin,
                "disabled-by-owner" => AutoSDKShared92580a598ccc210fDisabledReason.DisabledByOwner,
                "feature-not-available" => AutoSDKShared92580a598ccc210fDisabledReason.FeatureNotAvailable,
                "limits-exceeded" => AutoSDKShared92580a598ccc210fDisabledReason.LimitsExceeded,
                _ => null,
            };
        }
    }
}