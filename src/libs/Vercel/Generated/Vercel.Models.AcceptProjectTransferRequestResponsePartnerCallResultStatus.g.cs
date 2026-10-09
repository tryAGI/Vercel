
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AcceptProjectTransferRequestResponsePartnerCallResultStatus
    {
        /// <summary>
        ///
        /// </summary>
        Errored,
        /// <summary>
        ///
        /// </summary>
        Fulfilled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AcceptProjectTransferRequestResponsePartnerCallResultStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AcceptProjectTransferRequestResponsePartnerCallResultStatus value)
        {
            return value switch
            {
                AcceptProjectTransferRequestResponsePartnerCallResultStatus.Errored => "errored",
                AcceptProjectTransferRequestResponsePartnerCallResultStatus.Fulfilled => "fulfilled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AcceptProjectTransferRequestResponsePartnerCallResultStatus? ToEnum(string value)
        {
            return value switch
            {
                "errored" => AcceptProjectTransferRequestResponsePartnerCallResultStatus.Errored,
                "fulfilled" => AcceptProjectTransferRequestResponsePartnerCallResultStatus.Fulfilled,
                _ => null,
            };
        }
    }
}