
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum ActivateKmsSigningKeyResponseStatus
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
    public static class ActivateKmsSigningKeyResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActivateKmsSigningKeyResponseStatus value)
        {
            return value switch
            {
                ActivateKmsSigningKeyResponseStatus.Active => "active",
                ActivateKmsSigningKeyResponseStatus.Pending => "pending",
                ActivateKmsSigningKeyResponseStatus.Revoking => "revoking",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActivateKmsSigningKeyResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => ActivateKmsSigningKeyResponseStatus.Active,
                "pending" => ActivateKmsSigningKeyResponseStatus.Pending,
                "revoking" => ActivateKmsSigningKeyResponseStatus.Revoking,
                _ => null,
            };
        }
    }
}