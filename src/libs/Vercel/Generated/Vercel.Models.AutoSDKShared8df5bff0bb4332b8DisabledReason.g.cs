
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared8df5bff0bb4332b8DisabledReason
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
    public static class AutoSDKShared8df5bff0bb4332b8DisabledReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared8df5bff0bb4332b8DisabledReason value)
        {
            return value switch
            {
                AutoSDKShared8df5bff0bb4332b8DisabledReason.AccountPlanDowngrade => "account-plan-downgrade",
                AutoSDKShared8df5bff0bb4332b8DisabledReason.DisabledByAdmin => "disabled-by-admin",
                AutoSDKShared8df5bff0bb4332b8DisabledReason.DisabledByOwner => "disabled-by-owner",
                AutoSDKShared8df5bff0bb4332b8DisabledReason.FeatureNotAvailable => "feature-not-available",
                AutoSDKShared8df5bff0bb4332b8DisabledReason.LimitsExceeded => "limits-exceeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared8df5bff0bb4332b8DisabledReason? ToEnum(string value)
        {
            return value switch
            {
                "account-plan-downgrade" => AutoSDKShared8df5bff0bb4332b8DisabledReason.AccountPlanDowngrade,
                "disabled-by-admin" => AutoSDKShared8df5bff0bb4332b8DisabledReason.DisabledByAdmin,
                "disabled-by-owner" => AutoSDKShared8df5bff0bb4332b8DisabledReason.DisabledByOwner,
                "feature-not-available" => AutoSDKShared8df5bff0bb4332b8DisabledReason.FeatureNotAvailable,
                "limits-exceeded" => AutoSDKShared8df5bff0bb4332b8DisabledReason.LimitsExceeded,
                _ => null,
            };
        }
    }
}