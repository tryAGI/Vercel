
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6a7dd045a7a1bf61Algorithm
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
    public static class AutoSDKShared6a7dd045a7a1bf61AlgorithmExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6a7dd045a7a1bf61Algorithm value)
        {
            return value switch
            {
                AutoSDKShared6a7dd045a7a1bf61Algorithm.Es256 => "ES256",
                AutoSDKShared6a7dd045a7a1bf61Algorithm.Es384 => "ES384",
                AutoSDKShared6a7dd045a7a1bf61Algorithm.Es512 => "ES512",
                AutoSDKShared6a7dd045a7a1bf61Algorithm.Ps256 => "PS256",
                AutoSDKShared6a7dd045a7a1bf61Algorithm.Ps384 => "PS384",
                AutoSDKShared6a7dd045a7a1bf61Algorithm.Ps512 => "PS512",
                AutoSDKShared6a7dd045a7a1bf61Algorithm.Rs256 => "RS256",
                AutoSDKShared6a7dd045a7a1bf61Algorithm.Rs384 => "RS384",
                AutoSDKShared6a7dd045a7a1bf61Algorithm.Rs512 => "RS512",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6a7dd045a7a1bf61Algorithm? ToEnum(string value)
        {
            return value switch
            {
                "ES256" => AutoSDKShared6a7dd045a7a1bf61Algorithm.Es256,
                "ES384" => AutoSDKShared6a7dd045a7a1bf61Algorithm.Es384,
                "ES512" => AutoSDKShared6a7dd045a7a1bf61Algorithm.Es512,
                "PS256" => AutoSDKShared6a7dd045a7a1bf61Algorithm.Ps256,
                "PS384" => AutoSDKShared6a7dd045a7a1bf61Algorithm.Ps384,
                "PS512" => AutoSDKShared6a7dd045a7a1bf61Algorithm.Ps512,
                "RS256" => AutoSDKShared6a7dd045a7a1bf61Algorithm.Rs256,
                "RS384" => AutoSDKShared6a7dd045a7a1bf61Algorithm.Rs384,
                "RS512" => AutoSDKShared6a7dd045a7a1bf61Algorithm.Rs512,
                _ => null,
            };
        }
    }
}