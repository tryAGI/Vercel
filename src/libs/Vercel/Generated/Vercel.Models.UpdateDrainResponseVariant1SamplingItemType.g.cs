
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateDrainResponseVariant1SamplingItemType
    {
        /// <summary>
        /// 
        /// </summary>
        HeadSampling,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateDrainResponseVariant1SamplingItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDrainResponseVariant1SamplingItemType value)
        {
            return value switch
            {
                UpdateDrainResponseVariant1SamplingItemType.HeadSampling => "head_sampling",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDrainResponseVariant1SamplingItemType? ToEnum(string value)
        {
            return value switch
            {
                "head_sampling" => UpdateDrainResponseVariant1SamplingItemType.HeadSampling,
                _ => null,
            };
        }
    }
}