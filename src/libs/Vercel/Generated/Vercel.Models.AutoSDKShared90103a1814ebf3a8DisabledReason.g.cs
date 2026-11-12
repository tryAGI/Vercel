
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared90103a1814ebf3a8DisabledReason
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
    public static class AutoSDKShared90103a1814ebf3a8DisabledReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared90103a1814ebf3a8DisabledReason value)
        {
            return value switch
            {
                AutoSDKShared90103a1814ebf3a8DisabledReason.AccountPlanDowngrade => "account-plan-downgrade",
                AutoSDKShared90103a1814ebf3a8DisabledReason.DisabledByAdmin => "disabled-by-admin",
                AutoSDKShared90103a1814ebf3a8DisabledReason.DisabledByOwner => "disabled-by-owner",
                AutoSDKShared90103a1814ebf3a8DisabledReason.FeatureNotAvailable => "feature-not-available",
                AutoSDKShared90103a1814ebf3a8DisabledReason.LimitsExceeded => "limits-exceeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared90103a1814ebf3a8DisabledReason? ToEnum(string value)
        {
            return value switch
            {
                "account-plan-downgrade" => AutoSDKShared90103a1814ebf3a8DisabledReason.AccountPlanDowngrade,
                "disabled-by-admin" => AutoSDKShared90103a1814ebf3a8DisabledReason.DisabledByAdmin,
                "disabled-by-owner" => AutoSDKShared90103a1814ebf3a8DisabledReason.DisabledByOwner,
                "feature-not-available" => AutoSDKShared90103a1814ebf3a8DisabledReason.FeatureNotAvailable,
                "limits-exceeded" => AutoSDKShared90103a1814ebf3a8DisabledReason.LimitsExceeded,
                _ => null,
            };
        }
    }
}