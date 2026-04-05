
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Invoice state.
    /// </summary>
    public enum GetInvoiceResponseState
    {
        /// <summary>
        /// 
        /// </summary>
        Draft,
        /// <summary>
        /// 
        /// </summary>
        Invoiced,
        /// <summary>
        /// 
        /// </summary>
        Notpaid,
        /// <summary>
        /// 
        /// </summary>
        Overdue,
        /// <summary>
        /// 
        /// </summary>
        Paid,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        RefundRequested,
        /// <summary>
        /// 
        /// </summary>
        Refunded,
        /// <summary>
        /// 
        /// </summary>
        Scheduled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetInvoiceResponseStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetInvoiceResponseState value)
        {
            return value switch
            {
                GetInvoiceResponseState.Draft => "draft",
                GetInvoiceResponseState.Invoiced => "invoiced",
                GetInvoiceResponseState.Notpaid => "notpaid",
                GetInvoiceResponseState.Overdue => "overdue",
                GetInvoiceResponseState.Paid => "paid",
                GetInvoiceResponseState.Pending => "pending",
                GetInvoiceResponseState.RefundRequested => "refund_requested",
                GetInvoiceResponseState.Refunded => "refunded",
                GetInvoiceResponseState.Scheduled => "scheduled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetInvoiceResponseState? ToEnum(string value)
        {
            return value switch
            {
                "draft" => GetInvoiceResponseState.Draft,
                "invoiced" => GetInvoiceResponseState.Invoiced,
                "notpaid" => GetInvoiceResponseState.Notpaid,
                "overdue" => GetInvoiceResponseState.Overdue,
                "paid" => GetInvoiceResponseState.Paid,
                "pending" => GetInvoiceResponseState.Pending,
                "refund_requested" => GetInvoiceResponseState.RefundRequested,
                "refunded" => GetInvoiceResponseState.Refunded,
                "scheduled" => GetInvoiceResponseState.Scheduled,
                _ => null,
            };
        }
    }
}