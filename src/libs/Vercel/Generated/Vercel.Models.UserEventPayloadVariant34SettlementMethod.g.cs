
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant34SettlementMethod
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
    public static class UserEventPayloadVariant34SettlementMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant34SettlementMethod value)
        {
            return value switch
            {
                UserEventPayloadVariant34SettlementMethod.CreditedPaid => "credited-paid",
                UserEventPayloadVariant34SettlementMethod.RefundedPaid => "refunded-paid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant34SettlementMethod? ToEnum(string value)
        {
            return value switch
            {
                "credited-paid" => UserEventPayloadVariant34SettlementMethod.CreditedPaid,
                "refunded-paid" => UserEventPayloadVariant34SettlementMethod.RefundedPaid,
                _ => null,
            };
        }
    }
}