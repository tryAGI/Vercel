
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateInvoiceRequestAction
    {
        /// <summary>
        /// 
        /// </summary>
        Refund,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateInvoiceRequestActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateInvoiceRequestAction value)
        {
            return value switch
            {
                UpdateInvoiceRequestAction.Refund => "refund",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateInvoiceRequestAction? ToEnum(string value)
        {
            return value switch
            {
                "refund" => UpdateInvoiceRequestAction.Refund,
                _ => null,
            };
        }
    }
}