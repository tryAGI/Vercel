
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared383028c008cc4ae0SamplingItemType
    {
        /// <summary>
        ///
        /// </summary>
        HeadSampling,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared383028c008cc4ae0SamplingItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared383028c008cc4ae0SamplingItemType value)
        {
            return value switch
            {
                AutoSDKShared383028c008cc4ae0SamplingItemType.HeadSampling => "head_sampling",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared383028c008cc4ae0SamplingItemType? ToEnum(string value)
        {
            return value switch
            {
                "head_sampling" => AutoSDKShared383028c008cc4ae0SamplingItemType.HeadSampling,
                _ => null,
            };
        }
    }
}