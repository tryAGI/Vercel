
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared9f8c0585e20078fcDisabledReason
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
    public static class AutoSDKShared9f8c0585e20078fcDisabledReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared9f8c0585e20078fcDisabledReason value)
        {
            return value switch
            {
                AutoSDKShared9f8c0585e20078fcDisabledReason.AccountPlanDowngrade => "account-plan-downgrade",
                AutoSDKShared9f8c0585e20078fcDisabledReason.DisabledByAdmin => "disabled-by-admin",
                AutoSDKShared9f8c0585e20078fcDisabledReason.DisabledByOwner => "disabled-by-owner",
                AutoSDKShared9f8c0585e20078fcDisabledReason.FeatureNotAvailable => "feature-not-available",
                AutoSDKShared9f8c0585e20078fcDisabledReason.LimitsExceeded => "limits-exceeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared9f8c0585e20078fcDisabledReason? ToEnum(string value)
        {
            return value switch
            {
                "account-plan-downgrade" => AutoSDKShared9f8c0585e20078fcDisabledReason.AccountPlanDowngrade,
                "disabled-by-admin" => AutoSDKShared9f8c0585e20078fcDisabledReason.DisabledByAdmin,
                "disabled-by-owner" => AutoSDKShared9f8c0585e20078fcDisabledReason.DisabledByOwner,
                "feature-not-available" => AutoSDKShared9f8c0585e20078fcDisabledReason.FeatureNotAvailable,
                "limits-exceeded" => AutoSDKShared9f8c0585e20078fcDisabledReason.LimitsExceeded,
                _ => null,
            };
        }
    }
}