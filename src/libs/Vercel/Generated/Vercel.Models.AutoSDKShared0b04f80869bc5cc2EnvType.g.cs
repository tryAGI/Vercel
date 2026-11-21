
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0b04f80869bc5cc2EnvType
    {
        /// <summary>
        ///
        /// </summary>
        ServiceRef,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared0b04f80869bc5cc2EnvTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0b04f80869bc5cc2EnvType value)
        {
            return value switch
            {
                AutoSDKShared0b04f80869bc5cc2EnvType.ServiceRef => "service-ref",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0b04f80869bc5cc2EnvType? ToEnum(string value)
        {
            return value switch
            {
                "service-ref" => AutoSDKShared0b04f80869bc5cc2EnvType.ServiceRef,
                _ => null,
            };
        }
    }
}