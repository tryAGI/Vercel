
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum TestDrainRequestDeliveryVariant3Encoding
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
    public static class TestDrainRequestDeliveryVariant3EncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestDrainRequestDeliveryVariant3Encoding value)
        {
            return value switch
            {
                TestDrainRequestDeliveryVariant3Encoding.Json => "json",
                TestDrainRequestDeliveryVariant3Encoding.Ndjson => "ndjson",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestDrainRequestDeliveryVariant3Encoding? ToEnum(string value)
        {
            return value switch
            {
                "json" => TestDrainRequestDeliveryVariant3Encoding.Json,
                "ndjson" => TestDrainRequestDeliveryVariant3Encoding.Ndjson,
                _ => null,
            };
        }
    }
}