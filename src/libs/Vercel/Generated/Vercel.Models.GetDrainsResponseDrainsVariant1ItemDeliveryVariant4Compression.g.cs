
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDrainsResponseDrainsVariant1ItemDeliveryVariant4Compression
    {
        /// <summary>
        /// 
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDrainsResponseDrainsVariant1ItemDeliveryVariant4CompressionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDrainsResponseDrainsVariant1ItemDeliveryVariant4Compression value)
        {
            return value switch
            {
                GetDrainsResponseDrainsVariant1ItemDeliveryVariant4Compression.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDrainsResponseDrainsVariant1ItemDeliveryVariant4Compression? ToEnum(string value)
        {
            return value switch
            {
                "none" => GetDrainsResponseDrainsVariant1ItemDeliveryVariant4Compression.None,
                _ => null,
            };
        }
    }
}