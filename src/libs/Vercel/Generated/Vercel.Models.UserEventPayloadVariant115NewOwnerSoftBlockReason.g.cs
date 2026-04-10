
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant115NewOwnerSoftBlockReason
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
    public static class UserEventPayloadVariant115NewOwnerSoftBlockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant115NewOwnerSoftBlockReason value)
        {
            return value switch
            {
                UserEventPayloadVariant115NewOwnerSoftBlockReason.BlockedForPlatformAbuse => "BLOCKED_FOR_PLATFORM_ABUSE",
                UserEventPayloadVariant115NewOwnerSoftBlockReason.EnterpriseTrialEnded => "ENTERPRISE_TRIAL_ENDED",
                UserEventPayloadVariant115NewOwnerSoftBlockReason.FairUseLimitsExceeded => "FAIR_USE_LIMITS_EXCEEDED",
                UserEventPayloadVariant115NewOwnerSoftBlockReason.SubscriptionCanceled => "SUBSCRIPTION_CANCELED",
                UserEventPayloadVariant115NewOwnerSoftBlockReason.SubscriptionExpired => "SUBSCRIPTION_EXPIRED",
                UserEventPayloadVariant115NewOwnerSoftBlockReason.UnpaidInvoice => "UNPAID_INVOICE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant115NewOwnerSoftBlockReason? ToEnum(string value)
        {
            return value switch
            {
                "BLOCKED_FOR_PLATFORM_ABUSE" => UserEventPayloadVariant115NewOwnerSoftBlockReason.BlockedForPlatformAbuse,
                "ENTERPRISE_TRIAL_ENDED" => UserEventPayloadVariant115NewOwnerSoftBlockReason.EnterpriseTrialEnded,
                "FAIR_USE_LIMITS_EXCEEDED" => UserEventPayloadVariant115NewOwnerSoftBlockReason.FairUseLimitsExceeded,
                "SUBSCRIPTION_CANCELED" => UserEventPayloadVariant115NewOwnerSoftBlockReason.SubscriptionCanceled,
                "SUBSCRIPTION_EXPIRED" => UserEventPayloadVariant115NewOwnerSoftBlockReason.SubscriptionExpired,
                "UNPAID_INVOICE" => UserEventPayloadVariant115NewOwnerSoftBlockReason.UnpaidInvoice,
                _ => null,
            };
        }
    }
}