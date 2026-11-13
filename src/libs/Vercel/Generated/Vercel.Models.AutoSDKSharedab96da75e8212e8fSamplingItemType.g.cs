
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedab96da75e8212e8fSamplingItemType
    {
        /// <summary>
        ///
        /// </summary>
        HeadSampling,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedab96da75e8212e8fSamplingItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedab96da75e8212e8fSamplingItemType value)
        {
            return value switch
            {
                AutoSDKSharedab96da75e8212e8fSamplingItemType.HeadSampling => "head_sampling",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedab96da75e8212e8fSamplingItemType? ToEnum(string value)
        {
            return value switch
            {
                "head_sampling" => AutoSDKSharedab96da75e8212e8fSamplingItemType.HeadSampling,
                _ => null,
            };
        }
    }
}