
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetKmsIssuerResponseAlgorithm
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
    public static class GetKmsIssuerResponseAlgorithmExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetKmsIssuerResponseAlgorithm value)
        {
            return value switch
            {
                GetKmsIssuerResponseAlgorithm.Es256 => "ES256",
                GetKmsIssuerResponseAlgorithm.Es384 => "ES384",
                GetKmsIssuerResponseAlgorithm.Es512 => "ES512",
                GetKmsIssuerResponseAlgorithm.EdDSA => "EdDSA",
                GetKmsIssuerResponseAlgorithm.Ps256 => "PS256",
                GetKmsIssuerResponseAlgorithm.Ps384 => "PS384",
                GetKmsIssuerResponseAlgorithm.Ps512 => "PS512",
                GetKmsIssuerResponseAlgorithm.Rs256 => "RS256",
                GetKmsIssuerResponseAlgorithm.Rs384 => "RS384",
                GetKmsIssuerResponseAlgorithm.Rs512 => "RS512",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetKmsIssuerResponseAlgorithm? ToEnum(string value)
        {
            return value switch
            {
                "ES256" => GetKmsIssuerResponseAlgorithm.Es256,
                "ES384" => GetKmsIssuerResponseAlgorithm.Es384,
                "ES512" => GetKmsIssuerResponseAlgorithm.Es512,
                "EdDSA" => GetKmsIssuerResponseAlgorithm.EdDSA,
                "PS256" => GetKmsIssuerResponseAlgorithm.Ps256,
                "PS384" => GetKmsIssuerResponseAlgorithm.Ps384,
                "PS512" => GetKmsIssuerResponseAlgorithm.Ps512,
                "RS256" => GetKmsIssuerResponseAlgorithm.Rs256,
                "RS384" => GetKmsIssuerResponseAlgorithm.Rs384,
                "RS512" => GetKmsIssuerResponseAlgorithm.Rs512,
                _ => null,
            };
        }
    }
}