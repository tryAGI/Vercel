
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant42SettlementMethod
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
    public static class UserEventPayloadVariant42SettlementMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant42SettlementMethod value)
        {
            return value switch
            {
                UserEventPayloadVariant42SettlementMethod.CreditedPaid => "credited-paid",
                UserEventPayloadVariant42SettlementMethod.RefundedPaid => "refunded-paid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant42SettlementMethod? ToEnum(string value)
        {
            return value switch
            {
                "credited-paid" => UserEventPayloadVariant42SettlementMethod.CreditedPaid,
                "refunded-paid" => UserEventPayloadVariant42SettlementMethod.RefundedPaid,
                _ => null,
            };
        }
    }
}