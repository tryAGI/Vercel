
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum RevokeKmsSigningKeyResponseAlgorithm
    {
        /// <summary>
        ///
        /// </summary>
        Es256,
        /// <summary>
        ///
        /// </summary>
        Es384,
        /// <summary>
        ///
        /// </summary>
        Es512,
        /// <summary>
        ///
        /// </summary>
        EdDSA,
        /// <summary>
        ///
        /// </summary>
        Ps256,
        /// <summary>
        ///
        /// </summary>
        Ps384,
        /// <summary>
        ///
        /// </summary>
        Ps512,
        /// <summary>
        ///
        /// </summary>
        Rs256,
        /// <summary>
        ///
        /// </summary>
        Rs384,
        /// <summary>
        ///
        /// </summary>
        Rs512,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RevokeKmsSigningKeyResponseAlgorithmExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RevokeKmsSigningKeyResponseAlgorithm value)
        {
            return value switch
            {
                RevokeKmsSigningKeyResponseAlgorithm.Es256 => "ES256",
                RevokeKmsSigningKeyResponseAlgorithm.Es384 => "ES384",
                RevokeKmsSigningKeyResponseAlgorithm.Es512 => "ES512",
                RevokeKmsSigningKeyResponseAlgorithm.EdDSA => "EdDSA",
                RevokeKmsSigningKeyResponseAlgorithm.Ps256 => "PS256",
                RevokeKmsSigningKeyResponseAlgorithm.Ps384 => "PS384",
                RevokeKmsSigningKeyResponseAlgorithm.Ps512 => "PS512",
                RevokeKmsSigningKeyResponseAlgorithm.Rs256 => "RS256",
                RevokeKmsSigningKeyResponseAlgorithm.Rs384 => "RS384",
                RevokeKmsSigningKeyResponseAlgorithm.Rs512 => "RS512",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RevokeKmsSigningKeyResponseAlgorithm? ToEnum(string value)
        {
            return value switch
            {
                "ES256" => RevokeKmsSigningKeyResponseAlgorithm.Es256,
                "ES384" => RevokeKmsSigningKeyResponseAlgorithm.Es384,
                "ES512" => RevokeKmsSigningKeyResponseAlgorithm.Es512,
                "EdDSA" => RevokeKmsSigningKeyResponseAlgorithm.EdDSA,
                "PS256" => RevokeKmsSigningKeyResponseAlgorithm.Ps256,
                "PS384" => RevokeKmsSigningKeyResponseAlgorithm.Ps384,
                "PS512" => RevokeKmsSigningKeyResponseAlgorithm.Ps512,
                "RS256" => RevokeKmsSigningKeyResponseAlgorithm.Rs256,
                "RS384" => RevokeKmsSigningKeyResponseAlgorithm.Rs384,
                "RS512" => RevokeKmsSigningKeyResponseAlgorithm.Rs512,
                _ => null,
            };
        }
    }
}