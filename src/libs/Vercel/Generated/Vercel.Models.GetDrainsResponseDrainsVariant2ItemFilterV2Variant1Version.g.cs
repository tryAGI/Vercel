
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDrainsResponseDrainsVariant2ItemFilterV2Variant1Version
    {
        /// <summary>
        /// 
        /// </summary>
        V1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDrainsResponseDrainsVariant2ItemFilterV2Variant1VersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDrainsResponseDrainsVariant2ItemFilterV2Variant1Version value)
        {
            return value switch
            {
                GetDrainsResponseDrainsVariant2ItemFilterV2Variant1Version.V1 => "v1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDrainsResponseDrainsVariant2ItemFilterV2Variant1Version? ToEnum(string value)
        {
            return value switch
            {
                "v1" => GetDrainsResponseDrainsVariant2ItemFilterV2Variant1Version.V1,
                _ => null,
            };
        }
    }
}