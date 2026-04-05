
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDrainsResponseDrainsVariant2ItemFilterV2Variant2FilterVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Basic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDrainsResponseDrainsVariant2ItemFilterV2Variant2FilterVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDrainsResponseDrainsVariant2ItemFilterV2Variant2FilterVariant1Type value)
        {
            return value switch
            {
                GetDrainsResponseDrainsVariant2ItemFilterV2Variant2FilterVariant1Type.Basic => "basic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDrainsResponseDrainsVariant2ItemFilterV2Variant2FilterVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "basic" => GetDrainsResponseDrainsVariant2ItemFilterV2Variant2FilterVariant1Type.Basic,
                _ => null,
            };
        }
    }
}