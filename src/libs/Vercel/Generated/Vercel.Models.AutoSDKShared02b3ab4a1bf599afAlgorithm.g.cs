
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared02b3ab4a1bf599afAlgorithm
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
    public static class AutoSDKShared02b3ab4a1bf599afAlgorithmExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared02b3ab4a1bf599afAlgorithm value)
        {
            return value switch
            {
                AutoSDKShared02b3ab4a1bf599afAlgorithm.Es256 => "ES256",
                AutoSDKShared02b3ab4a1bf599afAlgorithm.Es384 => "ES384",
                AutoSDKShared02b3ab4a1bf599afAlgorithm.Es512 => "ES512",
                AutoSDKShared02b3ab4a1bf599afAlgorithm.Ps256 => "PS256",
                AutoSDKShared02b3ab4a1bf599afAlgorithm.Ps384 => "PS384",
                AutoSDKShared02b3ab4a1bf599afAlgorithm.Ps512 => "PS512",
                AutoSDKShared02b3ab4a1bf599afAlgorithm.Rs256 => "RS256",
                AutoSDKShared02b3ab4a1bf599afAlgorithm.Rs384 => "RS384",
                AutoSDKShared02b3ab4a1bf599afAlgorithm.Rs512 => "RS512",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared02b3ab4a1bf599afAlgorithm? ToEnum(string value)
        {
            return value switch
            {
                "ES256" => AutoSDKShared02b3ab4a1bf599afAlgorithm.Es256,
                "ES384" => AutoSDKShared02b3ab4a1bf599afAlgorithm.Es384,
                "ES512" => AutoSDKShared02b3ab4a1bf599afAlgorithm.Es512,
                "PS256" => AutoSDKShared02b3ab4a1bf599afAlgorithm.Ps256,
                "PS384" => AutoSDKShared02b3ab4a1bf599afAlgorithm.Ps384,
                "PS512" => AutoSDKShared02b3ab4a1bf599afAlgorithm.Ps512,
                "RS256" => AutoSDKShared02b3ab4a1bf599afAlgorithm.Rs256,
                "RS384" => AutoSDKShared02b3ab4a1bf599afAlgorithm.Rs384,
                "RS512" => AutoSDKShared02b3ab4a1bf599afAlgorithm.Rs512,
                _ => null,
            };
        }
    }
}