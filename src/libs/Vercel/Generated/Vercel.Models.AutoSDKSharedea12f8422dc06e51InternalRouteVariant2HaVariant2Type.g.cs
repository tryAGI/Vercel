
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedea12f8422dc06e51InternalRouteVariant2HaVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        Host,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedea12f8422dc06e51InternalRouteVariant2HaVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedea12f8422dc06e51InternalRouteVariant2HaVariant2Type value)
        {
            return value switch
            {
                AutoSDKSharedea12f8422dc06e51InternalRouteVariant2HaVariant2Type.Host => "host",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedea12f8422dc06e51InternalRouteVariant2HaVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "host" => AutoSDKSharedea12f8422dc06e51InternalRouteVariant2HaVariant2Type.Host,
                _ => null,
            };
        }
    }
}