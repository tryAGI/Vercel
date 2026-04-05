
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDrainsResponseDrainsVariant2ItemFilterV2Variant2Version
    {
        /// <summary>
        /// 
        /// </summary>
        V2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDrainsResponseDrainsVariant2ItemFilterV2Variant2VersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDrainsResponseDrainsVariant2ItemFilterV2Variant2Version value)
        {
            return value switch
            {
                GetDrainsResponseDrainsVariant2ItemFilterV2Variant2Version.V2 => "v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDrainsResponseDrainsVariant2ItemFilterV2Variant2Version? ToEnum(string value)
        {
            return value switch
            {
                "v2" => GetDrainsResponseDrainsVariant2ItemFilterV2Variant2Version.V2,
                _ => null,
            };
        }
    }
}