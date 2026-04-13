
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant36SettlementMethod
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
    public static class UserEventPayloadVariant36SettlementMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant36SettlementMethod value)
        {
            return value switch
            {
                UserEventPayloadVariant36SettlementMethod.CreditedPaid => "credited-paid",
                UserEventPayloadVariant36SettlementMethod.RefundedPaid => "refunded-paid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant36SettlementMethod? ToEnum(string value)
        {
            return value switch
            {
                "credited-paid" => UserEventPayloadVariant36SettlementMethod.CreditedPaid,
                "refunded-paid" => UserEventPayloadVariant36SettlementMethod.RefundedPaid,
                _ => null,
            };
        }
    }
}