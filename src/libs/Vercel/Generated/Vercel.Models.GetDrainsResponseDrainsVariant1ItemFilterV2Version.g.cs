
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDrainsResponseDrainsVariant1ItemFilterV2Version
    {
        /// <summary>
        /// 
        /// </summary>
        V2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDrainsResponseDrainsVariant1ItemFilterV2VersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDrainsResponseDrainsVariant1ItemFilterV2Version value)
        {
            return value switch
            {
                GetDrainsResponseDrainsVariant1ItemFilterV2Version.V2 => "v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDrainsResponseDrainsVariant1ItemFilterV2Version? ToEnum(string value)
        {
            return value switch
            {
                "v2" => GetDrainsResponseDrainsVariant1ItemFilterV2Version.V2,
                _ => null,
            };
        }
    }
}