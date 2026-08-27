
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateKmsIssuerResponseSigningKeyStatus
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
    public static class CreateKmsIssuerResponseSigningKeyStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateKmsIssuerResponseSigningKeyStatus value)
        {
            return value switch
            {
                CreateKmsIssuerResponseSigningKeyStatus.Active => "active",
                CreateKmsIssuerResponseSigningKeyStatus.Pending => "pending",
                CreateKmsIssuerResponseSigningKeyStatus.Revoking => "revoking",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateKmsIssuerResponseSigningKeyStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => CreateKmsIssuerResponseSigningKeyStatus.Active,
                "pending" => CreateKmsIssuerResponseSigningKeyStatus.Pending,
                "revoking" => CreateKmsIssuerResponseSigningKeyStatus.Revoking,
                _ => null,
            };
        }
    }
}