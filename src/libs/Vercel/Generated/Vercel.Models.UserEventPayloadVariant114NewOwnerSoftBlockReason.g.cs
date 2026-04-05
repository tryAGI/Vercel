
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant114NewOwnerSoftBlockReason
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
    public static class UserEventPayloadVariant114NewOwnerSoftBlockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant114NewOwnerSoftBlockReason value)
        {
            return value switch
            {
                UserEventPayloadVariant114NewOwnerSoftBlockReason.BlockedForPlatformAbuse => "BLOCKED_FOR_PLATFORM_ABUSE",
                UserEventPayloadVariant114NewOwnerSoftBlockReason.EnterpriseTrialEnded => "ENTERPRISE_TRIAL_ENDED",
                UserEventPayloadVariant114NewOwnerSoftBlockReason.FairUseLimitsExceeded => "FAIR_USE_LIMITS_EXCEEDED",
                UserEventPayloadVariant114NewOwnerSoftBlockReason.SubscriptionCanceled => "SUBSCRIPTION_CANCELED",
                UserEventPayloadVariant114NewOwnerSoftBlockReason.SubscriptionExpired => "SUBSCRIPTION_EXPIRED",
                UserEventPayloadVariant114NewOwnerSoftBlockReason.UnpaidInvoice => "UNPAID_INVOICE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant114NewOwnerSoftBlockReason? ToEnum(string value)
        {
            return value switch
            {
                "BLOCKED_FOR_PLATFORM_ABUSE" => UserEventPayloadVariant114NewOwnerSoftBlockReason.BlockedForPlatformAbuse,
                "ENTERPRISE_TRIAL_ENDED" => UserEventPayloadVariant114NewOwnerSoftBlockReason.EnterpriseTrialEnded,
                "FAIR_USE_LIMITS_EXCEEDED" => UserEventPayloadVariant114NewOwnerSoftBlockReason.FairUseLimitsExceeded,
                "SUBSCRIPTION_CANCELED" => UserEventPayloadVariant114NewOwnerSoftBlockReason.SubscriptionCanceled,
                "SUBSCRIPTION_EXPIRED" => UserEventPayloadVariant114NewOwnerSoftBlockReason.SubscriptionExpired,
                "UNPAID_INVOICE" => UserEventPayloadVariant114NewOwnerSoftBlockReason.UnpaidInvoice,
                _ => null,
            };
        }
    }
}