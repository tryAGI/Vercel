
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedab96da75e8212e8fDisabledReason
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
    public static class AutoSDKSharedab96da75e8212e8fDisabledReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedab96da75e8212e8fDisabledReason value)
        {
            return value switch
            {
                AutoSDKSharedab96da75e8212e8fDisabledReason.AccountPlanDowngrade => "account-plan-downgrade",
                AutoSDKSharedab96da75e8212e8fDisabledReason.DisabledByAdmin => "disabled-by-admin",
                AutoSDKSharedab96da75e8212e8fDisabledReason.DisabledByOwner => "disabled-by-owner",
                AutoSDKSharedab96da75e8212e8fDisabledReason.FeatureNotAvailable => "feature-not-available",
                AutoSDKSharedab96da75e8212e8fDisabledReason.LimitsExceeded => "limits-exceeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedab96da75e8212e8fDisabledReason? ToEnum(string value)
        {
            return value switch
            {
                "account-plan-downgrade" => AutoSDKSharedab96da75e8212e8fDisabledReason.AccountPlanDowngrade,
                "disabled-by-admin" => AutoSDKSharedab96da75e8212e8fDisabledReason.DisabledByAdmin,
                "disabled-by-owner" => AutoSDKSharedab96da75e8212e8fDisabledReason.DisabledByOwner,
                "feature-not-available" => AutoSDKSharedab96da75e8212e8fDisabledReason.FeatureNotAvailable,
                "limits-exceeded" => AutoSDKSharedab96da75e8212e8fDisabledReason.LimitsExceeded,
                _ => null,
            };
        }
    }
}