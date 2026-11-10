
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda861c3cb40ec56dcSamplingItemType
    {
        /// <summary>
        ///
        /// </summary>
        HeadSampling,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShareda861c3cb40ec56dcSamplingItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda861c3cb40ec56dcSamplingItemType value)
        {
            return value switch
            {
                AutoSDKShareda861c3cb40ec56dcSamplingItemType.HeadSampling => "head_sampling",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda861c3cb40ec56dcSamplingItemType? ToEnum(string value)
        {
            return value switch
            {
                "head_sampling" => AutoSDKShareda861c3cb40ec56dcSamplingItemType.HeadSampling,
                _ => null,
            };
        }
    }
}