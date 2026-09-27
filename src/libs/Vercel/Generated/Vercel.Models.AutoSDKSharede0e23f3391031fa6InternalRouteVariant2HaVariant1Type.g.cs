
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede0e23f3391031fa6InternalRouteVariant2HaVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        Header,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharede0e23f3391031fa6InternalRouteVariant2HaVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede0e23f3391031fa6InternalRouteVariant2HaVariant1Type value)
        {
            return value switch
            {
                AutoSDKSharede0e23f3391031fa6InternalRouteVariant2HaVariant1Type.Header => "header",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede0e23f3391031fa6InternalRouteVariant2HaVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "header" => AutoSDKSharede0e23f3391031fa6InternalRouteVariant2HaVariant1Type.Header,
                _ => null,
            };
        }
    }
}