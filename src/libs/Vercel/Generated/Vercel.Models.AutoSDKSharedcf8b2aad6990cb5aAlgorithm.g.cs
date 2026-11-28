
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedcf8b2aad6990cb5aAlgorithm
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
    public static class AutoSDKSharedcf8b2aad6990cb5aAlgorithmExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedcf8b2aad6990cb5aAlgorithm value)
        {
            return value switch
            {
                AutoSDKSharedcf8b2aad6990cb5aAlgorithm.Es256 => "ES256",
                AutoSDKSharedcf8b2aad6990cb5aAlgorithm.Es384 => "ES384",
                AutoSDKSharedcf8b2aad6990cb5aAlgorithm.Es512 => "ES512",
                AutoSDKSharedcf8b2aad6990cb5aAlgorithm.Ps256 => "PS256",
                AutoSDKSharedcf8b2aad6990cb5aAlgorithm.Ps384 => "PS384",
                AutoSDKSharedcf8b2aad6990cb5aAlgorithm.Ps512 => "PS512",
                AutoSDKSharedcf8b2aad6990cb5aAlgorithm.Rs256 => "RS256",
                AutoSDKSharedcf8b2aad6990cb5aAlgorithm.Rs384 => "RS384",
                AutoSDKSharedcf8b2aad6990cb5aAlgorithm.Rs512 => "RS512",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedcf8b2aad6990cb5aAlgorithm? ToEnum(string value)
        {
            return value switch
            {
                "ES256" => AutoSDKSharedcf8b2aad6990cb5aAlgorithm.Es256,
                "ES384" => AutoSDKSharedcf8b2aad6990cb5aAlgorithm.Es384,
                "ES512" => AutoSDKSharedcf8b2aad6990cb5aAlgorithm.Es512,
                "PS256" => AutoSDKSharedcf8b2aad6990cb5aAlgorithm.Ps256,
                "PS384" => AutoSDKSharedcf8b2aad6990cb5aAlgorithm.Ps384,
                "PS512" => AutoSDKSharedcf8b2aad6990cb5aAlgorithm.Ps512,
                "RS256" => AutoSDKSharedcf8b2aad6990cb5aAlgorithm.Rs256,
                "RS384" => AutoSDKSharedcf8b2aad6990cb5aAlgorithm.Rs384,
                "RS512" => AutoSDKSharedcf8b2aad6990cb5aAlgorithm.Rs512,
                _ => null,
            };
        }
    }
}