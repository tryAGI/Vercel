
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListKmsIssuersResponseIssuerSigningKeyStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Revoking,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListKmsIssuersResponseIssuerSigningKeyStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListKmsIssuersResponseIssuerSigningKeyStatus value)
        {
            return value switch
            {
                ListKmsIssuersResponseIssuerSigningKeyStatus.Active => "active",
                ListKmsIssuersResponseIssuerSigningKeyStatus.Pending => "pending",
                ListKmsIssuersResponseIssuerSigningKeyStatus.Revoking => "revoking",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListKmsIssuersResponseIssuerSigningKeyStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => ListKmsIssuersResponseIssuerSigningKeyStatus.Active,
                "pending" => ListKmsIssuersResponseIssuerSigningKeyStatus.Pending,
                "revoking" => ListKmsIssuersResponseIssuerSigningKeyStatus.Revoking,
                _ => null,
            };
        }
    }
}