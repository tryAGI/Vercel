
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum RevokeKmsSigningKeyResponseSigningKeyStatus
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
    public static class RevokeKmsSigningKeyResponseSigningKeyStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RevokeKmsSigningKeyResponseSigningKeyStatus value)
        {
            return value switch
            {
                RevokeKmsSigningKeyResponseSigningKeyStatus.Active => "active",
                RevokeKmsSigningKeyResponseSigningKeyStatus.Pending => "pending",
                RevokeKmsSigningKeyResponseSigningKeyStatus.Revoking => "revoking",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RevokeKmsSigningKeyResponseSigningKeyStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => RevokeKmsSigningKeyResponseSigningKeyStatus.Active,
                "pending" => RevokeKmsSigningKeyResponseSigningKeyStatus.Pending,
                "revoking" => RevokeKmsSigningKeyResponseSigningKeyStatus.Revoking,
                _ => null,
            };
        }
    }
}