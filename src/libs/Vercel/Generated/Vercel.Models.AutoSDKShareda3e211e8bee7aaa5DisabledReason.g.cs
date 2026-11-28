
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda3e211e8bee7aaa5DisabledReason
    {
        /// <summary>
        ///
        /// </summary>
        AccountPlanDowngrade,
        /// <summary>
        ///
        /// </summary>
        AutoPausedDeliveryErrors,
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
    public static class AutoSDKShareda3e211e8bee7aaa5DisabledReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda3e211e8bee7aaa5DisabledReason value)
        {
            return value switch
            {
                AutoSDKShareda3e211e8bee7aaa5DisabledReason.AccountPlanDowngrade => "account-plan-downgrade",
                AutoSDKShareda3e211e8bee7aaa5DisabledReason.AutoPausedDeliveryErrors => "auto-paused-delivery-errors",
                AutoSDKShareda3e211e8bee7aaa5DisabledReason.DisabledByAdmin => "disabled-by-admin",
                AutoSDKShareda3e211e8bee7aaa5DisabledReason.DisabledByOwner => "disabled-by-owner",
                AutoSDKShareda3e211e8bee7aaa5DisabledReason.FeatureNotAvailable => "feature-not-available",
                AutoSDKShareda3e211e8bee7aaa5DisabledReason.LimitsExceeded => "limits-exceeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda3e211e8bee7aaa5DisabledReason? ToEnum(string value)
        {
            return value switch
            {
                "account-plan-downgrade" => AutoSDKShareda3e211e8bee7aaa5DisabledReason.AccountPlanDowngrade,
                "auto-paused-delivery-errors" => AutoSDKShareda3e211e8bee7aaa5DisabledReason.AutoPausedDeliveryErrors,
                "disabled-by-admin" => AutoSDKShareda3e211e8bee7aaa5DisabledReason.DisabledByAdmin,
                "disabled-by-owner" => AutoSDKShareda3e211e8bee7aaa5DisabledReason.DisabledByOwner,
                "feature-not-available" => AutoSDKShareda3e211e8bee7aaa5DisabledReason.FeatureNotAvailable,
                "limits-exceeded" => AutoSDKShareda3e211e8bee7aaa5DisabledReason.LimitsExceeded,
                _ => null,
            };
        }
    }
}