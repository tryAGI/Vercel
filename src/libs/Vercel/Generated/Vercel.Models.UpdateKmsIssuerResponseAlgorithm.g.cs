
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateKmsIssuerResponseAlgorithm
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
    public static class UpdateKmsIssuerResponseAlgorithmExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateKmsIssuerResponseAlgorithm value)
        {
            return value switch
            {
                UpdateKmsIssuerResponseAlgorithm.Es256 => "ES256",
                UpdateKmsIssuerResponseAlgorithm.Es384 => "ES384",
                UpdateKmsIssuerResponseAlgorithm.Es512 => "ES512",
                UpdateKmsIssuerResponseAlgorithm.EdDSA => "EdDSA",
                UpdateKmsIssuerResponseAlgorithm.Ps256 => "PS256",
                UpdateKmsIssuerResponseAlgorithm.Ps384 => "PS384",
                UpdateKmsIssuerResponseAlgorithm.Ps512 => "PS512",
                UpdateKmsIssuerResponseAlgorithm.Rs256 => "RS256",
                UpdateKmsIssuerResponseAlgorithm.Rs384 => "RS384",
                UpdateKmsIssuerResponseAlgorithm.Rs512 => "RS512",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateKmsIssuerResponseAlgorithm? ToEnum(string value)
        {
            return value switch
            {
                "ES256" => UpdateKmsIssuerResponseAlgorithm.Es256,
                "ES384" => UpdateKmsIssuerResponseAlgorithm.Es384,
                "ES512" => UpdateKmsIssuerResponseAlgorithm.Es512,
                "EdDSA" => UpdateKmsIssuerResponseAlgorithm.EdDSA,
                "PS256" => UpdateKmsIssuerResponseAlgorithm.Ps256,
                "PS384" => UpdateKmsIssuerResponseAlgorithm.Ps384,
                "PS512" => UpdateKmsIssuerResponseAlgorithm.Ps512,
                "RS256" => UpdateKmsIssuerResponseAlgorithm.Rs256,
                "RS384" => UpdateKmsIssuerResponseAlgorithm.Rs384,
                "RS512" => UpdateKmsIssuerResponseAlgorithm.Rs512,
                _ => null,
            };
        }
    }
}