
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum RevokeKmsSigningKeyResponsePolicieVariant2Kind
    {
        /// <summary>
        ///
        /// </summary>
        ConnexGrant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RevokeKmsSigningKeyResponsePolicieVariant2KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RevokeKmsSigningKeyResponsePolicieVariant2Kind value)
        {
            return value switch
            {
                RevokeKmsSigningKeyResponsePolicieVariant2Kind.ConnexGrant => "connex-grant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RevokeKmsSigningKeyResponsePolicieVariant2Kind? ToEnum(string value)
        {
            return value switch
            {
                "connex-grant" => RevokeKmsSigningKeyResponsePolicieVariant2Kind.ConnexGrant,
                _ => null,
            };
        }
    }
}