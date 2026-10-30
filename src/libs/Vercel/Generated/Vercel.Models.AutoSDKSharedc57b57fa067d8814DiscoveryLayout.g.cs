
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedc57b57fa067d8814DiscoveryLayout
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
    public static class AutoSDKSharedc57b57fa067d8814DiscoveryLayoutExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc57b57fa067d8814DiscoveryLayout value)
        {
            return value switch
            {
                AutoSDKSharedc57b57fa067d8814DiscoveryLayout.Connect => "connect",
                AutoSDKSharedc57b57fa067d8814DiscoveryLayout.Kms => "kms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc57b57fa067d8814DiscoveryLayout? ToEnum(string value)
        {
            return value switch
            {
                "connect" => AutoSDKSharedc57b57fa067d8814DiscoveryLayout.Connect,
                "kms" => AutoSDKSharedc57b57fa067d8814DiscoveryLayout.Kms,
                _ => null,
            };
        }
    }
}