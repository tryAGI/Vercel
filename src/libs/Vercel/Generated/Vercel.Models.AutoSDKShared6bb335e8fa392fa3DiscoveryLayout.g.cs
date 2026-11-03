
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6bb335e8fa392fa3DiscoveryLayout
    {
        /// <summary>
        ///
        /// </summary>
        Connect,
        /// <summary>
        ///
        /// </summary>
        Kms,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared6bb335e8fa392fa3DiscoveryLayoutExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6bb335e8fa392fa3DiscoveryLayout value)
        {
            return value switch
            {
                AutoSDKShared6bb335e8fa392fa3DiscoveryLayout.Connect => "connect",
                AutoSDKShared6bb335e8fa392fa3DiscoveryLayout.Kms => "kms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6bb335e8fa392fa3DiscoveryLayout? ToEnum(string value)
        {
            return value switch
            {
                "connect" => AutoSDKShared6bb335e8fa392fa3DiscoveryLayout.Connect,
                "kms" => AutoSDKShared6bb335e8fa392fa3DiscoveryLayout.Kms,
                _ => null,
            };
        }
    }
}