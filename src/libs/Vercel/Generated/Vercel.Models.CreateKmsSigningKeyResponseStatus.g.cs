
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateKmsSigningKeyResponseStatus
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
    public static class CreateKmsSigningKeyResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateKmsSigningKeyResponseStatus value)
        {
            return value switch
            {
                CreateKmsSigningKeyResponseStatus.Active => "active",
                CreateKmsSigningKeyResponseStatus.Pending => "pending",
                CreateKmsSigningKeyResponseStatus.Revoking => "revoking",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateKmsSigningKeyResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => CreateKmsSigningKeyResponseStatus.Active,
                "pending" => CreateKmsSigningKeyResponseStatus.Pending,
                "revoking" => CreateKmsSigningKeyResponseStatus.Revoking,
                _ => null,
            };
        }
    }
}