
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum AcceptProjectTransferRequestResponseVariant1PartnerCallResultStatus
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
    public static class AcceptProjectTransferRequestResponseVariant1PartnerCallResultStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AcceptProjectTransferRequestResponseVariant1PartnerCallResultStatus value)
        {
            return value switch
            {
                AcceptProjectTransferRequestResponseVariant1PartnerCallResultStatus.Errored => "errored",
                AcceptProjectTransferRequestResponseVariant1PartnerCallResultStatus.Fulfilled => "fulfilled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AcceptProjectTransferRequestResponseVariant1PartnerCallResultStatus? ToEnum(string value)
        {
            return value switch
            {
                "errored" => AcceptProjectTransferRequestResponseVariant1PartnerCallResultStatus.Errored,
                "fulfilled" => AcceptProjectTransferRequestResponseVariant1PartnerCallResultStatus.Fulfilled,
                _ => null,
            };
        }
    }
}