
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared9c06dfe8dd59ad6dDisabledReason
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
    public static class AutoSDKShared9c06dfe8dd59ad6dDisabledReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared9c06dfe8dd59ad6dDisabledReason value)
        {
            return value switch
            {
                AutoSDKShared9c06dfe8dd59ad6dDisabledReason.AccountPlanDowngrade => "account-plan-downgrade",
                AutoSDKShared9c06dfe8dd59ad6dDisabledReason.DisabledByAdmin => "disabled-by-admin",
                AutoSDKShared9c06dfe8dd59ad6dDisabledReason.DisabledByOwner => "disabled-by-owner",
                AutoSDKShared9c06dfe8dd59ad6dDisabledReason.FeatureNotAvailable => "feature-not-available",
                AutoSDKShared9c06dfe8dd59ad6dDisabledReason.LimitsExceeded => "limits-exceeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared9c06dfe8dd59ad6dDisabledReason? ToEnum(string value)
        {
            return value switch
            {
                "account-plan-downgrade" => AutoSDKShared9c06dfe8dd59ad6dDisabledReason.AccountPlanDowngrade,
                "disabled-by-admin" => AutoSDKShared9c06dfe8dd59ad6dDisabledReason.DisabledByAdmin,
                "disabled-by-owner" => AutoSDKShared9c06dfe8dd59ad6dDisabledReason.DisabledByOwner,
                "feature-not-available" => AutoSDKShared9c06dfe8dd59ad6dDisabledReason.FeatureNotAvailable,
                "limits-exceeded" => AutoSDKShared9c06dfe8dd59ad6dDisabledReason.LimitsExceeded,
                _ => null,
            };
        }
    }
}