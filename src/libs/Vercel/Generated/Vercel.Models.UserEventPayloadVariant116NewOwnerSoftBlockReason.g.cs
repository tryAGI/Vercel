
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant116NewOwnerSoftBlockReason
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
    public static class UserEventPayloadVariant116NewOwnerSoftBlockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant116NewOwnerSoftBlockReason value)
        {
            return value switch
            {
                UserEventPayloadVariant116NewOwnerSoftBlockReason.BlockedForPlatformAbuse => "BLOCKED_FOR_PLATFORM_ABUSE",
                UserEventPayloadVariant116NewOwnerSoftBlockReason.EnterpriseTrialEnded => "ENTERPRISE_TRIAL_ENDED",
                UserEventPayloadVariant116NewOwnerSoftBlockReason.FairUseLimitsExceeded => "FAIR_USE_LIMITS_EXCEEDED",
                UserEventPayloadVariant116NewOwnerSoftBlockReason.SubscriptionCanceled => "SUBSCRIPTION_CANCELED",
                UserEventPayloadVariant116NewOwnerSoftBlockReason.SubscriptionExpired => "SUBSCRIPTION_EXPIRED",
                UserEventPayloadVariant116NewOwnerSoftBlockReason.UnpaidInvoice => "UNPAID_INVOICE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant116NewOwnerSoftBlockReason? ToEnum(string value)
        {
            return value switch
            {
                "BLOCKED_FOR_PLATFORM_ABUSE" => UserEventPayloadVariant116NewOwnerSoftBlockReason.BlockedForPlatformAbuse,
                "ENTERPRISE_TRIAL_ENDED" => UserEventPayloadVariant116NewOwnerSoftBlockReason.EnterpriseTrialEnded,
                "FAIR_USE_LIMITS_EXCEEDED" => UserEventPayloadVariant116NewOwnerSoftBlockReason.FairUseLimitsExceeded,
                "SUBSCRIPTION_CANCELED" => UserEventPayloadVariant116NewOwnerSoftBlockReason.SubscriptionCanceled,
                "SUBSCRIPTION_EXPIRED" => UserEventPayloadVariant116NewOwnerSoftBlockReason.SubscriptionExpired,
                "UNPAID_INVOICE" => UserEventPayloadVariant116NewOwnerSoftBlockReason.UnpaidInvoice,
                _ => null,
            };
        }
    }
}