
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared56f06376e757011bDisabledReason
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
    public static class AutoSDKShared56f06376e757011bDisabledReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared56f06376e757011bDisabledReason value)
        {
            return value switch
            {
                AutoSDKShared56f06376e757011bDisabledReason.AccountPlanDowngrade => "account-plan-downgrade",
                AutoSDKShared56f06376e757011bDisabledReason.DisabledByAdmin => "disabled-by-admin",
                AutoSDKShared56f06376e757011bDisabledReason.DisabledByOwner => "disabled-by-owner",
                AutoSDKShared56f06376e757011bDisabledReason.FeatureNotAvailable => "feature-not-available",
                AutoSDKShared56f06376e757011bDisabledReason.LimitsExceeded => "limits-exceeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared56f06376e757011bDisabledReason? ToEnum(string value)
        {
            return value switch
            {
                "account-plan-downgrade" => AutoSDKShared56f06376e757011bDisabledReason.AccountPlanDowngrade,
                "disabled-by-admin" => AutoSDKShared56f06376e757011bDisabledReason.DisabledByAdmin,
                "disabled-by-owner" => AutoSDKShared56f06376e757011bDisabledReason.DisabledByOwner,
                "feature-not-available" => AutoSDKShared56f06376e757011bDisabledReason.FeatureNotAvailable,
                "limits-exceeded" => AutoSDKShared56f06376e757011bDisabledReason.LimitsExceeded,
                _ => null,
            };
        }
    }
}