
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant1LogSource
    {
        /// <summary>
        /// 
        /// </summary>
        Build,
        /// <summary>
        /// 
        /// </summary>
        Edge,
        /// <summary>
        /// 
        /// </summary>
        External,
        /// <summary>
        /// 
        /// </summary>
        Firewall,
        /// <summary>
        /// 
        /// </summary>
        Lambda,
        /// <summary>
        /// 
        /// </summary>
        Redirect,
        /// <summary>
        /// 
        /// </summary>
        Static,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant1LogSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant1LogSource value)
        {
            return value switch
            {
                GetDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant1LogSource.Build => "build",
                GetDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant1LogSource.Edge => "edge",
                GetDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant1LogSource.External => "external",
                GetDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant1LogSource.Firewall => "firewall",
                GetDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant1LogSource.Lambda => "lambda",
                GetDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant1LogSource.Redirect => "redirect",
                GetDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant1LogSource.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant1LogSource? ToEnum(string value)
        {
            return value switch
            {
                "build" => GetDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant1LogSource.Build,
                "edge" => GetDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant1LogSource.Edge,
                "external" => GetDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant1LogSource.External,
                "firewall" => GetDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant1LogSource.Firewall,
                "lambda" => GetDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant1LogSource.Lambda,
                "redirect" => GetDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant1LogSource.Redirect,
                "static" => GetDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant1LogSource.Static,
                _ => null,
            };
        }
    }
}