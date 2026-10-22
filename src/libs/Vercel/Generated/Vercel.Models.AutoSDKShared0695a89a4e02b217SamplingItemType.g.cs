
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0695a89a4e02b217SamplingItemType
    {
        /// <summary>
        ///
        /// </summary>
        HeadSampling,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared0695a89a4e02b217SamplingItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0695a89a4e02b217SamplingItemType value)
        {
            return value switch
            {
                AutoSDKShared0695a89a4e02b217SamplingItemType.HeadSampling => "head_sampling",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0695a89a4e02b217SamplingItemType? ToEnum(string value)
        {
            return value switch
            {
                "head_sampling" => AutoSDKShared0695a89a4e02b217SamplingItemType.HeadSampling,
                _ => null,
            };
        }
    }
}