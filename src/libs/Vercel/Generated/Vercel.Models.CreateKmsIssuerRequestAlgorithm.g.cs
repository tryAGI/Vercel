
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The signing algorithm to use for the issuer.<br/>
    /// Default Value: RS512
    /// </summary>
    public enum CreateKmsIssuerRequestAlgorithm
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
    public static class CreateKmsIssuerRequestAlgorithmExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateKmsIssuerRequestAlgorithm value)
        {
            return value switch
            {
                CreateKmsIssuerRequestAlgorithm.Es256 => "ES256",
                CreateKmsIssuerRequestAlgorithm.Es384 => "ES384",
                CreateKmsIssuerRequestAlgorithm.Es512 => "ES512",
                CreateKmsIssuerRequestAlgorithm.EdDSA => "EdDSA",
                CreateKmsIssuerRequestAlgorithm.Ps256 => "PS256",
                CreateKmsIssuerRequestAlgorithm.Ps384 => "PS384",
                CreateKmsIssuerRequestAlgorithm.Ps512 => "PS512",
                CreateKmsIssuerRequestAlgorithm.Rs256 => "RS256",
                CreateKmsIssuerRequestAlgorithm.Rs384 => "RS384",
                CreateKmsIssuerRequestAlgorithm.Rs512 => "RS512",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateKmsIssuerRequestAlgorithm? ToEnum(string value)
        {
            return value switch
            {
                "ES256" => CreateKmsIssuerRequestAlgorithm.Es256,
                "ES384" => CreateKmsIssuerRequestAlgorithm.Es384,
                "ES512" => CreateKmsIssuerRequestAlgorithm.Es512,
                "EdDSA" => CreateKmsIssuerRequestAlgorithm.EdDSA,
                "PS256" => CreateKmsIssuerRequestAlgorithm.Ps256,
                "PS384" => CreateKmsIssuerRequestAlgorithm.Ps384,
                "PS512" => CreateKmsIssuerRequestAlgorithm.Ps512,
                "RS256" => CreateKmsIssuerRequestAlgorithm.Rs256,
                "RS384" => CreateKmsIssuerRequestAlgorithm.Rs384,
                "RS512" => CreateKmsIssuerRequestAlgorithm.Rs512,
                _ => null,
            };
        }
    }
}