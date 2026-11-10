
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared8df5bff0bb4332b8SamplingItemType
    {
        /// <summary>
        ///
        /// </summary>
        HeadSampling,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared8df5bff0bb4332b8SamplingItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared8df5bff0bb4332b8SamplingItemType value)
        {
            return value switch
            {
                AutoSDKShared8df5bff0bb4332b8SamplingItemType.HeadSampling => "head_sampling",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared8df5bff0bb4332b8SamplingItemType? ToEnum(string value)
        {
            return value switch
            {
                "head_sampling" => AutoSDKShared8df5bff0bb4332b8SamplingItemType.HeadSampling,
                _ => null,
            };
        }
    }
}