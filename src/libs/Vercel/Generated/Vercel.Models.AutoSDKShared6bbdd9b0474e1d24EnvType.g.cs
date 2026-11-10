
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6bbdd9b0474e1d24EnvType
    {
        /// <summary>
        ///
        /// </summary>
        ServiceRef,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared6bbdd9b0474e1d24EnvTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6bbdd9b0474e1d24EnvType value)
        {
            return value switch
            {
                AutoSDKShared6bbdd9b0474e1d24EnvType.ServiceRef => "service-ref",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6bbdd9b0474e1d24EnvType? ToEnum(string value)
        {
            return value switch
            {
                "service-ref" => AutoSDKShared6bbdd9b0474e1d24EnvType.ServiceRef,
                _ => null,
            };
        }
    }
}