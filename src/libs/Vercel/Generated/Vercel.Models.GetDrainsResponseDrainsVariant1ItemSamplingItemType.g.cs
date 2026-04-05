
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDrainsResponseDrainsVariant1ItemSamplingItemType
    {
        /// <summary>
        /// 
        /// </summary>
        HeadSampling,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDrainsResponseDrainsVariant1ItemSamplingItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDrainsResponseDrainsVariant1ItemSamplingItemType value)
        {
            return value switch
            {
                GetDrainsResponseDrainsVariant1ItemSamplingItemType.HeadSampling => "head_sampling",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDrainsResponseDrainsVariant1ItemSamplingItemType? ToEnum(string value)
        {
            return value switch
            {
                "head_sampling" => GetDrainsResponseDrainsVariant1ItemSamplingItemType.HeadSampling,
                _ => null,
            };
        }
    }
}