
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum AuthUserSoftBlockReason
    {
        /// <summary>
        /// 
        /// </summary>
        BlockedForPlatformAbuse,
        /// <summary>
        /// 
        /// </summary>
        EnterpriseTrialEnded,
        /// <summary>
        /// 
        /// </summary>
        FairUseLimitsExceeded,
        /// <summary>
        /// 
        /// </summary>
        SubscriptionCanceled,
        /// <summary>
        /// 
        /// </summary>
        SubscriptionExpired,
        /// <summary>
        /// 
        /// </summary>
        UnpaidInvoice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuthUserSoftBlockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthUserSoftBlockReason value)
        {
            return value switch
            {
                AuthUserSoftBlockReason.BlockedForPlatformAbuse => "BLOCKED_FOR_PLATFORM_ABUSE",
                AuthUserSoftBlockReason.EnterpriseTrialEnded => "ENTERPRISE_TRIAL_ENDED",
                AuthUserSoftBlockReason.FairUseLimitsExceeded => "FAIR_USE_LIMITS_EXCEEDED",
                AuthUserSoftBlockReason.SubscriptionCanceled => "SUBSCRIPTION_CANCELED",
                AuthUserSoftBlockReason.SubscriptionExpired => "SUBSCRIPTION_EXPIRED",
                AuthUserSoftBlockReason.UnpaidInvoice => "UNPAID_INVOICE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthUserSoftBlockReason? ToEnum(string value)
        {
            return value switch
            {
                "BLOCKED_FOR_PLATFORM_ABUSE" => AuthUserSoftBlockReason.BlockedForPlatformAbuse,
                "ENTERPRISE_TRIAL_ENDED" => AuthUserSoftBlockReason.EnterpriseTrialEnded,
                "FAIR_USE_LIMITS_EXCEEDED" => AuthUserSoftBlockReason.FairUseLimitsExceeded,
                "SUBSCRIPTION_CANCELED" => AuthUserSoftBlockReason.SubscriptionCanceled,
                "SUBSCRIPTION_EXPIRED" => AuthUserSoftBlockReason.SubscriptionExpired,
                "UNPAID_INVOICE" => AuthUserSoftBlockReason.UnpaidInvoice,
                _ => null,
            };
        }
    }
}