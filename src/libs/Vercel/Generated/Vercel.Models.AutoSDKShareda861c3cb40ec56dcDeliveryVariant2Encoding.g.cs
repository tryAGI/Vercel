
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda861c3cb40ec56dcDeliveryVariant2Encoding
    {
        /// <summary>
        ///
        /// </summary>
        Json,
        /// <summary>
        ///
        /// </summary>
        Proto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShareda861c3cb40ec56dcDeliveryVariant2EncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda861c3cb40ec56dcDeliveryVariant2Encoding value)
        {
            return value switch
            {
                AutoSDKShareda861c3cb40ec56dcDeliveryVariant2Encoding.Json => "json",
                AutoSDKShareda861c3cb40ec56dcDeliveryVariant2Encoding.Proto => "proto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda861c3cb40ec56dcDeliveryVariant2Encoding? ToEnum(string value)
        {
            return value switch
            {
                "json" => AutoSDKShareda861c3cb40ec56dcDeliveryVariant2Encoding.Json,
                "proto" => AutoSDKShareda861c3cb40ec56dcDeliveryVariant2Encoding.Proto,
                _ => null,
            };
        }
    }
}