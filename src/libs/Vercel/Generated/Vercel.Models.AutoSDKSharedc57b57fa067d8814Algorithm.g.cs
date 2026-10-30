
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedc57b57fa067d8814Algorithm
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
    public static class AutoSDKSharedc57b57fa067d8814AlgorithmExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc57b57fa067d8814Algorithm value)
        {
            return value switch
            {
                AutoSDKSharedc57b57fa067d8814Algorithm.Es256 => "ES256",
                AutoSDKSharedc57b57fa067d8814Algorithm.Es384 => "ES384",
                AutoSDKSharedc57b57fa067d8814Algorithm.Es512 => "ES512",
                AutoSDKSharedc57b57fa067d8814Algorithm.Ps256 => "PS256",
                AutoSDKSharedc57b57fa067d8814Algorithm.Ps384 => "PS384",
                AutoSDKSharedc57b57fa067d8814Algorithm.Ps512 => "PS512",
                AutoSDKSharedc57b57fa067d8814Algorithm.Rs256 => "RS256",
                AutoSDKSharedc57b57fa067d8814Algorithm.Rs384 => "RS384",
                AutoSDKSharedc57b57fa067d8814Algorithm.Rs512 => "RS512",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc57b57fa067d8814Algorithm? ToEnum(string value)
        {
            return value switch
            {
                "ES256" => AutoSDKSharedc57b57fa067d8814Algorithm.Es256,
                "ES384" => AutoSDKSharedc57b57fa067d8814Algorithm.Es384,
                "ES512" => AutoSDKSharedc57b57fa067d8814Algorithm.Es512,
                "PS256" => AutoSDKSharedc57b57fa067d8814Algorithm.Ps256,
                "PS384" => AutoSDKSharedc57b57fa067d8814Algorithm.Ps384,
                "PS512" => AutoSDKSharedc57b57fa067d8814Algorithm.Ps512,
                "RS256" => AutoSDKSharedc57b57fa067d8814Algorithm.Rs256,
                "RS384" => AutoSDKSharedc57b57fa067d8814Algorithm.Rs384,
                "RS512" => AutoSDKSharedc57b57fa067d8814Algorithm.Rs512,
                _ => null,
            };
        }
    }
}