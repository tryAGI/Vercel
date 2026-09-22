
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared9c06dfe8dd59ad6dSamplingItemType
    {
        /// <summary>
        ///
        /// </summary>
        HeadSampling,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared9c06dfe8dd59ad6dSamplingItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared9c06dfe8dd59ad6dSamplingItemType value)
        {
            return value switch
            {
                AutoSDKShared9c06dfe8dd59ad6dSamplingItemType.HeadSampling => "head_sampling",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared9c06dfe8dd59ad6dSamplingItemType? ToEnum(string value)
        {
            return value switch
            {
                "head_sampling" => AutoSDKShared9c06dfe8dd59ad6dSamplingItemType.HeadSampling,
                _ => null,
            };
        }
    }
}