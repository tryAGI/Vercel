
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda861c3cb40ec56dcDeliveryVariant4Encoding
    {
        /// <summary>
        ///
        /// </summary>
        Json,
        /// <summary>
        ///
        /// </summary>
        Ndjson,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShareda861c3cb40ec56dcDeliveryVariant4EncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda861c3cb40ec56dcDeliveryVariant4Encoding value)
        {
            return value switch
            {
                AutoSDKShareda861c3cb40ec56dcDeliveryVariant4Encoding.Json => "json",
                AutoSDKShareda861c3cb40ec56dcDeliveryVariant4Encoding.Ndjson => "ndjson",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda861c3cb40ec56dcDeliveryVariant4Encoding? ToEnum(string value)
        {
            return value switch
            {
                "json" => AutoSDKShareda861c3cb40ec56dcDeliveryVariant4Encoding.Json,
                "ndjson" => AutoSDKShareda861c3cb40ec56dcDeliveryVariant4Encoding.Ndjson,
                _ => null,
            };
        }
    }
}