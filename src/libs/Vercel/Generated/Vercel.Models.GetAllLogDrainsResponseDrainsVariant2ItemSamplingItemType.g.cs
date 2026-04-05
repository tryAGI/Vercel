
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAllLogDrainsResponseDrainsVariant2ItemSamplingItemType
    {
        /// <summary>
        /// 
        /// </summary>
        HeadSampling,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAllLogDrainsResponseDrainsVariant2ItemSamplingItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAllLogDrainsResponseDrainsVariant2ItemSamplingItemType value)
        {
            return value switch
            {
                GetAllLogDrainsResponseDrainsVariant2ItemSamplingItemType.HeadSampling => "head_sampling",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAllLogDrainsResponseDrainsVariant2ItemSamplingItemType? ToEnum(string value)
        {
            return value switch
            {
                "head_sampling" => GetAllLogDrainsResponseDrainsVariant2ItemSamplingItemType.HeadSampling,
                _ => null,
            };
        }
    }
}