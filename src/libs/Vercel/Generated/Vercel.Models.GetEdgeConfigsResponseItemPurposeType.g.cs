
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetEdgeConfigsResponseItemPurposeType
    {
        /// <summary>
        /// 
        /// </summary>
        Flags,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetEdgeConfigsResponseItemPurposeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetEdgeConfigsResponseItemPurposeType value)
        {
            return value switch
            {
                GetEdgeConfigsResponseItemPurposeType.Flags => "flags",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetEdgeConfigsResponseItemPurposeType? ToEnum(string value)
        {
            return value switch
            {
                "flags" => GetEdgeConfigsResponseItemPurposeType.Flags,
                _ => null,
            };
        }
    }
}