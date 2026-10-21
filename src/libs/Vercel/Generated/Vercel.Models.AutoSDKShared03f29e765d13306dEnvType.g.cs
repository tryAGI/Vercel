
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared03f29e765d13306dEnvType
    {
        /// <summary>
        ///
        /// </summary>
        ServiceRef,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared03f29e765d13306dEnvTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared03f29e765d13306dEnvType value)
        {
            return value switch
            {
                AutoSDKShared03f29e765d13306dEnvType.ServiceRef => "service-ref",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared03f29e765d13306dEnvType? ToEnum(string value)
        {
            return value switch
            {
                "service-ref" => AutoSDKShared03f29e765d13306dEnvType.ServiceRef,
                _ => null,
            };
        }
    }
}