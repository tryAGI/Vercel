
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared2b02cf1378da97a7DisabledReason
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
    public static class AutoSDKShared2b02cf1378da97a7DisabledReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared2b02cf1378da97a7DisabledReason value)
        {
            return value switch
            {
                AutoSDKShared2b02cf1378da97a7DisabledReason.AccountPlanDowngrade => "account-plan-downgrade",
                AutoSDKShared2b02cf1378da97a7DisabledReason.AutoPausedDeliveryErrors => "auto-paused-delivery-errors",
                AutoSDKShared2b02cf1378da97a7DisabledReason.DisabledByAdmin => "disabled-by-admin",
                AutoSDKShared2b02cf1378da97a7DisabledReason.DisabledByOwner => "disabled-by-owner",
                AutoSDKShared2b02cf1378da97a7DisabledReason.FeatureNotAvailable => "feature-not-available",
                AutoSDKShared2b02cf1378da97a7DisabledReason.LimitsExceeded => "limits-exceeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared2b02cf1378da97a7DisabledReason? ToEnum(string value)
        {
            return value switch
            {
                "account-plan-downgrade" => AutoSDKShared2b02cf1378da97a7DisabledReason.AccountPlanDowngrade,
                "auto-paused-delivery-errors" => AutoSDKShared2b02cf1378da97a7DisabledReason.AutoPausedDeliveryErrors,
                "disabled-by-admin" => AutoSDKShared2b02cf1378da97a7DisabledReason.DisabledByAdmin,
                "disabled-by-owner" => AutoSDKShared2b02cf1378da97a7DisabledReason.DisabledByOwner,
                "feature-not-available" => AutoSDKShared2b02cf1378da97a7DisabledReason.FeatureNotAvailable,
                "limits-exceeded" => AutoSDKShared2b02cf1378da97a7DisabledReason.LimitsExceeded,
                _ => null,
            };
        }
    }
}