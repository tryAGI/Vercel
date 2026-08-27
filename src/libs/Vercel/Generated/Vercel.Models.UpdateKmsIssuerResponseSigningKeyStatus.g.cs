
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateKmsIssuerResponseSigningKeyStatus
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
    public static class UpdateKmsIssuerResponseSigningKeyStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateKmsIssuerResponseSigningKeyStatus value)
        {
            return value switch
            {
                UpdateKmsIssuerResponseSigningKeyStatus.Active => "active",
                UpdateKmsIssuerResponseSigningKeyStatus.Pending => "pending",
                UpdateKmsIssuerResponseSigningKeyStatus.Revoking => "revoking",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateKmsIssuerResponseSigningKeyStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => UpdateKmsIssuerResponseSigningKeyStatus.Active,
                "pending" => UpdateKmsIssuerResponseSigningKeyStatus.Pending,
                "revoking" => UpdateKmsIssuerResponseSigningKeyStatus.Revoking,
                _ => null,
            };
        }
    }
}