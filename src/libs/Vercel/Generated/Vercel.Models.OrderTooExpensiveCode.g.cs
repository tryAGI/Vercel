
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum OrderTooExpensiveCode
    {
        /// <summary>
        /// 
        /// </summary>
        OrderTooExpensive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrderTooExpensiveCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrderTooExpensiveCode value)
        {
            return value switch
            {
                OrderTooExpensiveCode.OrderTooExpensive => "order_too_expensive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrderTooExpensiveCode? ToEnum(string value)
        {
            return value switch
            {
                "order_too_expensive" => OrderTooExpensiveCode.OrderTooExpensive,
                _ => null,
            };
        }
    }
}