
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListKmsIssuersResponseIssuerAlgorithm
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
    public static class ListKmsIssuersResponseIssuerAlgorithmExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListKmsIssuersResponseIssuerAlgorithm value)
        {
            return value switch
            {
                ListKmsIssuersResponseIssuerAlgorithm.Es256 => "ES256",
                ListKmsIssuersResponseIssuerAlgorithm.Es384 => "ES384",
                ListKmsIssuersResponseIssuerAlgorithm.Es512 => "ES512",
                ListKmsIssuersResponseIssuerAlgorithm.EdDSA => "EdDSA",
                ListKmsIssuersResponseIssuerAlgorithm.Ps256 => "PS256",
                ListKmsIssuersResponseIssuerAlgorithm.Ps384 => "PS384",
                ListKmsIssuersResponseIssuerAlgorithm.Ps512 => "PS512",
                ListKmsIssuersResponseIssuerAlgorithm.Rs256 => "RS256",
                ListKmsIssuersResponseIssuerAlgorithm.Rs384 => "RS384",
                ListKmsIssuersResponseIssuerAlgorithm.Rs512 => "RS512",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListKmsIssuersResponseIssuerAlgorithm? ToEnum(string value)
        {
            return value switch
            {
                "ES256" => ListKmsIssuersResponseIssuerAlgorithm.Es256,
                "ES384" => ListKmsIssuersResponseIssuerAlgorithm.Es384,
                "ES512" => ListKmsIssuersResponseIssuerAlgorithm.Es512,
                "EdDSA" => ListKmsIssuersResponseIssuerAlgorithm.EdDSA,
                "PS256" => ListKmsIssuersResponseIssuerAlgorithm.Ps256,
                "PS384" => ListKmsIssuersResponseIssuerAlgorithm.Ps384,
                "PS512" => ListKmsIssuersResponseIssuerAlgorithm.Ps512,
                "RS256" => ListKmsIssuersResponseIssuerAlgorithm.Rs256,
                "RS384" => ListKmsIssuersResponseIssuerAlgorithm.Rs384,
                "RS512" => ListKmsIssuersResponseIssuerAlgorithm.Rs512,
                _ => null,
            };
        }
    }
}