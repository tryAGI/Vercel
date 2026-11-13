
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0001bb8e789a120eDisabledReason
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
    public static class AutoSDKShared0001bb8e789a120eDisabledReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0001bb8e789a120eDisabledReason value)
        {
            return value switch
            {
                AutoSDKShared0001bb8e789a120eDisabledReason.AccountPlanDowngrade => "account-plan-downgrade",
                AutoSDKShared0001bb8e789a120eDisabledReason.DisabledByAdmin => "disabled-by-admin",
                AutoSDKShared0001bb8e789a120eDisabledReason.DisabledByOwner => "disabled-by-owner",
                AutoSDKShared0001bb8e789a120eDisabledReason.FeatureNotAvailable => "feature-not-available",
                AutoSDKShared0001bb8e789a120eDisabledReason.LimitsExceeded => "limits-exceeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0001bb8e789a120eDisabledReason? ToEnum(string value)
        {
            return value switch
            {
                "account-plan-downgrade" => AutoSDKShared0001bb8e789a120eDisabledReason.AccountPlanDowngrade,
                "disabled-by-admin" => AutoSDKShared0001bb8e789a120eDisabledReason.DisabledByAdmin,
                "disabled-by-owner" => AutoSDKShared0001bb8e789a120eDisabledReason.DisabledByOwner,
                "feature-not-available" => AutoSDKShared0001bb8e789a120eDisabledReason.FeatureNotAvailable,
                "limits-exceeded" => AutoSDKShared0001bb8e789a120eDisabledReason.LimitsExceeded,
                _ => null,
            };
        }
    }
}