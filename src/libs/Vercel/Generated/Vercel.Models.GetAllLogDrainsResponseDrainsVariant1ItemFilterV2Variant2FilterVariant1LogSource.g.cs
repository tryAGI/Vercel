
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAllLogDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant1LogSource
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
    public static class GetAllLogDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant1LogSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAllLogDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant1LogSource value)
        {
            return value switch
            {
                GetAllLogDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant1LogSource.Build => "build",
                GetAllLogDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant1LogSource.Edge => "edge",
                GetAllLogDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant1LogSource.External => "external",
                GetAllLogDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant1LogSource.Firewall => "firewall",
                GetAllLogDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant1LogSource.Lambda => "lambda",
                GetAllLogDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant1LogSource.Redirect => "redirect",
                GetAllLogDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant1LogSource.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAllLogDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant1LogSource? ToEnum(string value)
        {
            return value switch
            {
                "build" => GetAllLogDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant1LogSource.Build,
                "edge" => GetAllLogDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant1LogSource.Edge,
                "external" => GetAllLogDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant1LogSource.External,
                "firewall" => GetAllLogDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant1LogSource.Firewall,
                "lambda" => GetAllLogDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant1LogSource.Lambda,
                "redirect" => GetAllLogDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant1LogSource.Redirect,
                "static" => GetAllLogDrainsResponseDrainsVariant1ItemFilterV2Variant2FilterVariant1LogSource.Static,
                _ => null,
            };
        }
    }
}