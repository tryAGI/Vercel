
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum TestDrainRequestDeliveryVariant1Encoding
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
    public static class TestDrainRequestDeliveryVariant1EncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestDrainRequestDeliveryVariant1Encoding value)
        {
            return value switch
            {
                TestDrainRequestDeliveryVariant1Encoding.Json => "json",
                TestDrainRequestDeliveryVariant1Encoding.Ndjson => "ndjson",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestDrainRequestDeliveryVariant1Encoding? ToEnum(string value)
        {
            return value switch
            {
                "json" => TestDrainRequestDeliveryVariant1Encoding.Json,
                "ndjson" => TestDrainRequestDeliveryVariant1Encoding.Ndjson,
                _ => null,
            };
        }
    }
}