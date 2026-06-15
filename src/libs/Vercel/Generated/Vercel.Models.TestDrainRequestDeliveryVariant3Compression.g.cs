
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum TestDrainRequestDeliveryVariant3Compression
    {
        /// <summary>
        /// 
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TestDrainRequestDeliveryVariant3CompressionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestDrainRequestDeliveryVariant3Compression value)
        {
            return value switch
            {
                TestDrainRequestDeliveryVariant3Compression.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestDrainRequestDeliveryVariant3Compression? ToEnum(string value)
        {
            return value switch
            {
                "none" => TestDrainRequestDeliveryVariant3Compression.None,
                _ => null,
            };
        }
    }
}