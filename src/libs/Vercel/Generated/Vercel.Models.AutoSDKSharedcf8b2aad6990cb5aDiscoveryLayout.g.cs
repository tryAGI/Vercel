
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedcf8b2aad6990cb5aDiscoveryLayout
    {
        /// <summary>
        ///
        /// </summary>
        Connect,
        /// <summary>
        ///
        /// </summary>
        Integrations,
        /// <summary>
        ///
        /// </summary>
        Kms,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedcf8b2aad6990cb5aDiscoveryLayoutExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedcf8b2aad6990cb5aDiscoveryLayout value)
        {
            return value switch
            {
                AutoSDKSharedcf8b2aad6990cb5aDiscoveryLayout.Connect => "connect",
                AutoSDKSharedcf8b2aad6990cb5aDiscoveryLayout.Integrations => "integrations",
                AutoSDKSharedcf8b2aad6990cb5aDiscoveryLayout.Kms => "kms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedcf8b2aad6990cb5aDiscoveryLayout? ToEnum(string value)
        {
            return value switch
            {
                "connect" => AutoSDKSharedcf8b2aad6990cb5aDiscoveryLayout.Connect,
                "integrations" => AutoSDKSharedcf8b2aad6990cb5aDiscoveryLayout.Integrations,
                "kms" => AutoSDKSharedcf8b2aad6990cb5aDiscoveryLayout.Kms,
                _ => null,
            };
        }
    }
}