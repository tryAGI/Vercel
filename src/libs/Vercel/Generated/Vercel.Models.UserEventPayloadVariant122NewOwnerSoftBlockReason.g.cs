
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant122NewOwnerSoftBlockReason
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
        EnterpriseUnpaidInvoice,
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
    public static class UserEventPayloadVariant122NewOwnerSoftBlockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant122NewOwnerSoftBlockReason value)
        {
            return value switch
            {
                UserEventPayloadVariant122NewOwnerSoftBlockReason.BlockedForPlatformAbuse => "BLOCKED_FOR_PLATFORM_ABUSE",
                UserEventPayloadVariant122NewOwnerSoftBlockReason.EnterpriseTrialEnded => "ENTERPRISE_TRIAL_ENDED",
                UserEventPayloadVariant122NewOwnerSoftBlockReason.EnterpriseUnpaidInvoice => "ENTERPRISE_UNPAID_INVOICE",
                UserEventPayloadVariant122NewOwnerSoftBlockReason.FairUseLimitsExceeded => "FAIR_USE_LIMITS_EXCEEDED",
                UserEventPayloadVariant122NewOwnerSoftBlockReason.SubscriptionCanceled => "SUBSCRIPTION_CANCELED",
                UserEventPayloadVariant122NewOwnerSoftBlockReason.SubscriptionExpired => "SUBSCRIPTION_EXPIRED",
                UserEventPayloadVariant122NewOwnerSoftBlockReason.UnpaidInvoice => "UNPAID_INVOICE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant122NewOwnerSoftBlockReason? ToEnum(string value)
        {
            return value switch
            {
                "BLOCKED_FOR_PLATFORM_ABUSE" => UserEventPayloadVariant122NewOwnerSoftBlockReason.BlockedForPlatformAbuse,
                "ENTERPRISE_TRIAL_ENDED" => UserEventPayloadVariant122NewOwnerSoftBlockReason.EnterpriseTrialEnded,
                "ENTERPRISE_UNPAID_INVOICE" => UserEventPayloadVariant122NewOwnerSoftBlockReason.EnterpriseUnpaidInvoice,
                "FAIR_USE_LIMITS_EXCEEDED" => UserEventPayloadVariant122NewOwnerSoftBlockReason.FairUseLimitsExceeded,
                "SUBSCRIPTION_CANCELED" => UserEventPayloadVariant122NewOwnerSoftBlockReason.SubscriptionCanceled,
                "SUBSCRIPTION_EXPIRED" => UserEventPayloadVariant122NewOwnerSoftBlockReason.SubscriptionExpired,
                "UNPAID_INVOICE" => UserEventPayloadVariant122NewOwnerSoftBlockReason.UnpaidInvoice,
                _ => null,
            };
        }
    }
}