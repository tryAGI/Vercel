
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDomainTransferInResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Canceled,
        /// <summary>
        /// 
        /// </summary>
        CanceledPendingRefund,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Created,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        PendingInsert,
        /// <summary>
        /// 
        /// </summary>
        PendingNewAuthCode,
        /// <summary>
        /// 
        /// </summary>
        PendingRegistryUnlock,
        /// <summary>
        /// 
        /// </summary>
        PendingTransfer,
        /// <summary>
        /// 
        /// </summary>
        PendingUnlock,
        /// <summary>
        /// 
        /// </summary>
        Rejected,
        /// <summary>
        /// 
        /// </summary>
        SubmittingTransfer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDomainTransferInResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDomainTransferInResponseStatus value)
        {
            return value switch
            {
                GetDomainTransferInResponseStatus.Canceled => "canceled",
                GetDomainTransferInResponseStatus.CanceledPendingRefund => "canceled_pending_refund",
                GetDomainTransferInResponseStatus.Completed => "completed",
                GetDomainTransferInResponseStatus.Created => "created",
                GetDomainTransferInResponseStatus.Failed => "failed",
                GetDomainTransferInResponseStatus.Pending => "pending",
                GetDomainTransferInResponseStatus.PendingInsert => "pending_insert",
                GetDomainTransferInResponseStatus.PendingNewAuthCode => "pending_new_auth_code",
                GetDomainTransferInResponseStatus.PendingRegistryUnlock => "pending_registry_unlock",
                GetDomainTransferInResponseStatus.PendingTransfer => "pending_transfer",
                GetDomainTransferInResponseStatus.PendingUnlock => "pending_unlock",
                GetDomainTransferInResponseStatus.Rejected => "rejected",
                GetDomainTransferInResponseStatus.SubmittingTransfer => "submitting_transfer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDomainTransferInResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => GetDomainTransferInResponseStatus.Canceled,
                "canceled_pending_refund" => GetDomainTransferInResponseStatus.CanceledPendingRefund,
                "completed" => GetDomainTransferInResponseStatus.Completed,
                "created" => GetDomainTransferInResponseStatus.Created,
                "failed" => GetDomainTransferInResponseStatus.Failed,
                "pending" => GetDomainTransferInResponseStatus.Pending,
                "pending_insert" => GetDomainTransferInResponseStatus.PendingInsert,
                "pending_new_auth_code" => GetDomainTransferInResponseStatus.PendingNewAuthCode,
                "pending_registry_unlock" => GetDomainTransferInResponseStatus.PendingRegistryUnlock,
                "pending_transfer" => GetDomainTransferInResponseStatus.PendingTransfer,
                "pending_unlock" => GetDomainTransferInResponseStatus.PendingUnlock,
                "rejected" => GetDomainTransferInResponseStatus.Rejected,
                "submitting_transfer" => GetDomainTransferInResponseStatus.SubmittingTransfer,
                _ => null,
            };
        }
    }
}