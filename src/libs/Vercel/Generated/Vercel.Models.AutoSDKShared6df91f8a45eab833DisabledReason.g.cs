
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6df91f8a45eab833DisabledReason
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
    public static class AutoSDKShared6df91f8a45eab833DisabledReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6df91f8a45eab833DisabledReason value)
        {
            return value switch
            {
                AutoSDKShared6df91f8a45eab833DisabledReason.AccountPlanDowngrade => "account-plan-downgrade",
                AutoSDKShared6df91f8a45eab833DisabledReason.DisabledByAdmin => "disabled-by-admin",
                AutoSDKShared6df91f8a45eab833DisabledReason.DisabledByOwner => "disabled-by-owner",
                AutoSDKShared6df91f8a45eab833DisabledReason.FeatureNotAvailable => "feature-not-available",
                AutoSDKShared6df91f8a45eab833DisabledReason.LimitsExceeded => "limits-exceeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6df91f8a45eab833DisabledReason? ToEnum(string value)
        {
            return value switch
            {
                "account-plan-downgrade" => AutoSDKShared6df91f8a45eab833DisabledReason.AccountPlanDowngrade,
                "disabled-by-admin" => AutoSDKShared6df91f8a45eab833DisabledReason.DisabledByAdmin,
                "disabled-by-owner" => AutoSDKShared6df91f8a45eab833DisabledReason.DisabledByOwner,
                "feature-not-available" => AutoSDKShared6df91f8a45eab833DisabledReason.FeatureNotAvailable,
                "limits-exceeded" => AutoSDKShared6df91f8a45eab833DisabledReason.LimitsExceeded,
                _ => null,
            };
        }
    }
}