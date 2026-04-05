
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum TestDrainRequestDeliveryVariant2Encoding
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
    public static class TestDrainRequestDeliveryVariant2EncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestDrainRequestDeliveryVariant2Encoding value)
        {
            return value switch
            {
                TestDrainRequestDeliveryVariant2Encoding.Json => "json",
                TestDrainRequestDeliveryVariant2Encoding.Proto => "proto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestDrainRequestDeliveryVariant2Encoding? ToEnum(string value)
        {
            return value switch
            {
                "json" => TestDrainRequestDeliveryVariant2Encoding.Json,
                "proto" => TestDrainRequestDeliveryVariant2Encoding.Proto,
                _ => null,
            };
        }
    }
}