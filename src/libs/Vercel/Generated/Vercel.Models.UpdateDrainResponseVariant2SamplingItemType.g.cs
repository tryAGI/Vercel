
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateDrainResponseVariant2SamplingItemType
    {
        /// <summary>
        /// 
        /// </summary>
        HeadSampling,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateDrainResponseVariant2SamplingItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDrainResponseVariant2SamplingItemType value)
        {
            return value switch
            {
                UpdateDrainResponseVariant2SamplingItemType.HeadSampling => "head_sampling",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDrainResponseVariant2SamplingItemType? ToEnum(string value)
        {
            return value switch
            {
                "head_sampling" => UpdateDrainResponseVariant2SamplingItemType.HeadSampling,
                _ => null,
            };
        }
    }
}