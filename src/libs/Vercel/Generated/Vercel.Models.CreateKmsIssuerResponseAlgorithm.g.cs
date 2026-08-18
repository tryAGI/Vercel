
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateKmsIssuerResponseAlgorithm
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
    public static class CreateKmsIssuerResponseAlgorithmExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateKmsIssuerResponseAlgorithm value)
        {
            return value switch
            {
                CreateKmsIssuerResponseAlgorithm.Es256 => "ES256",
                CreateKmsIssuerResponseAlgorithm.Es384 => "ES384",
                CreateKmsIssuerResponseAlgorithm.Es512 => "ES512",
                CreateKmsIssuerResponseAlgorithm.EdDSA => "EdDSA",
                CreateKmsIssuerResponseAlgorithm.Ps256 => "PS256",
                CreateKmsIssuerResponseAlgorithm.Ps384 => "PS384",
                CreateKmsIssuerResponseAlgorithm.Ps512 => "PS512",
                CreateKmsIssuerResponseAlgorithm.Rs256 => "RS256",
                CreateKmsIssuerResponseAlgorithm.Rs384 => "RS384",
                CreateKmsIssuerResponseAlgorithm.Rs512 => "RS512",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateKmsIssuerResponseAlgorithm? ToEnum(string value)
        {
            return value switch
            {
                "ES256" => CreateKmsIssuerResponseAlgorithm.Es256,
                "ES384" => CreateKmsIssuerResponseAlgorithm.Es384,
                "ES512" => CreateKmsIssuerResponseAlgorithm.Es512,
                "EdDSA" => CreateKmsIssuerResponseAlgorithm.EdDSA,
                "PS256" => CreateKmsIssuerResponseAlgorithm.Ps256,
                "PS384" => CreateKmsIssuerResponseAlgorithm.Ps384,
                "PS512" => CreateKmsIssuerResponseAlgorithm.Ps512,
                "RS256" => CreateKmsIssuerResponseAlgorithm.Rs256,
                "RS384" => CreateKmsIssuerResponseAlgorithm.Rs384,
                "RS512" => CreateKmsIssuerResponseAlgorithm.Rs512,
                _ => null,
            };
        }
    }
}