
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetKmsIssuerResponseSigningKeyStatus
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
    public static class GetKmsIssuerResponseSigningKeyStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetKmsIssuerResponseSigningKeyStatus value)
        {
            return value switch
            {
                GetKmsIssuerResponseSigningKeyStatus.Active => "active",
                GetKmsIssuerResponseSigningKeyStatus.Pending => "pending",
                GetKmsIssuerResponseSigningKeyStatus.Revoking => "revoking",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetKmsIssuerResponseSigningKeyStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => GetKmsIssuerResponseSigningKeyStatus.Active,
                "pending" => GetKmsIssuerResponseSigningKeyStatus.Pending,
                "revoking" => GetKmsIssuerResponseSigningKeyStatus.Revoking,
                _ => null,
            };
        }
    }
}