
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedd5d6c9ab94c25f66DisabledReason
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
    public static class AutoSDKSharedd5d6c9ab94c25f66DisabledReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedd5d6c9ab94c25f66DisabledReason value)
        {
            return value switch
            {
                AutoSDKSharedd5d6c9ab94c25f66DisabledReason.AccountPlanDowngrade => "account-plan-downgrade",
                AutoSDKSharedd5d6c9ab94c25f66DisabledReason.DisabledByAdmin => "disabled-by-admin",
                AutoSDKSharedd5d6c9ab94c25f66DisabledReason.DisabledByOwner => "disabled-by-owner",
                AutoSDKSharedd5d6c9ab94c25f66DisabledReason.FeatureNotAvailable => "feature-not-available",
                AutoSDKSharedd5d6c9ab94c25f66DisabledReason.LimitsExceeded => "limits-exceeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedd5d6c9ab94c25f66DisabledReason? ToEnum(string value)
        {
            return value switch
            {
                "account-plan-downgrade" => AutoSDKSharedd5d6c9ab94c25f66DisabledReason.AccountPlanDowngrade,
                "disabled-by-admin" => AutoSDKSharedd5d6c9ab94c25f66DisabledReason.DisabledByAdmin,
                "disabled-by-owner" => AutoSDKSharedd5d6c9ab94c25f66DisabledReason.DisabledByOwner,
                "feature-not-available" => AutoSDKSharedd5d6c9ab94c25f66DisabledReason.FeatureNotAvailable,
                "limits-exceeded" => AutoSDKSharedd5d6c9ab94c25f66DisabledReason.LimitsExceeded,
                _ => null,
            };
        }
    }
}