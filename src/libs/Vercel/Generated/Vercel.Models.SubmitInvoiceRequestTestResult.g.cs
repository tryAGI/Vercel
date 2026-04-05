
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubmitInvoiceRequestTestResult
    {
        /// <summary>
        /// 
        /// </summary>
        Notpaid,
        /// <summary>
        /// 
        /// </summary>
        Paid,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubmitInvoiceRequestTestResultExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubmitInvoiceRequestTestResult value)
        {
            return value switch
            {
                SubmitInvoiceRequestTestResult.Notpaid => "notpaid",
                SubmitInvoiceRequestTestResult.Paid => "paid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubmitInvoiceRequestTestResult? ToEnum(string value)
        {
            return value switch
            {
                "notpaid" => SubmitInvoiceRequestTestResult.Notpaid,
                "paid" => SubmitInvoiceRequestTestResult.Paid,
                _ => null,
            };
        }
    }
}