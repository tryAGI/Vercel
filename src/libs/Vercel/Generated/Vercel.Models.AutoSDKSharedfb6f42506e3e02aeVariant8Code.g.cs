
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedfb6f42506e3e02aeVariant8Code
    {
        /// <summary>
        ///
        /// </summary>
        PriceChange,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedfb6f42506e3e02aeVariant8CodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedfb6f42506e3e02aeVariant8Code value)
        {
            return value switch
            {
                AutoSDKSharedfb6f42506e3e02aeVariant8Code.PriceChange => "price-change",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedfb6f42506e3e02aeVariant8Code? ToEnum(string value)
        {
            return value switch
            {
                "price-change" => AutoSDKSharedfb6f42506e3e02aeVariant8Code.PriceChange,
                _ => null,
            };
        }
    }
}