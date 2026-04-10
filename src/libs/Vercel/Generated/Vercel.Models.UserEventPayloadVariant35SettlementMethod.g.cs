
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant35SettlementMethod
    {
        /// <summary>
        /// 
        /// </summary>
        CreditedPaid,
        /// <summary>
        /// 
        /// </summary>
        RefundedPaid,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant35SettlementMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant35SettlementMethod value)
        {
            return value switch
            {
                UserEventPayloadVariant35SettlementMethod.CreditedPaid => "credited-paid",
                UserEventPayloadVariant35SettlementMethod.RefundedPaid => "refunded-paid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant35SettlementMethod? ToEnum(string value)
        {
            return value switch
            {
                "credited-paid" => UserEventPayloadVariant35SettlementMethod.CreditedPaid,
                "refunded-paid" => UserEventPayloadVariant35SettlementMethod.RefundedPaid,
                _ => null,
            };
        }
    }
}