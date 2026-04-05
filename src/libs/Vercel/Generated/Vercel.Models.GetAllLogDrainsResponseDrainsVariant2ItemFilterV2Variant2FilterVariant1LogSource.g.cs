
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAllLogDrainsResponseDrainsVariant2ItemFilterV2Variant2FilterVariant1LogSource
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
    public static class GetAllLogDrainsResponseDrainsVariant2ItemFilterV2Variant2FilterVariant1LogSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAllLogDrainsResponseDrainsVariant2ItemFilterV2Variant2FilterVariant1LogSource value)
        {
            return value switch
            {
                GetAllLogDrainsResponseDrainsVariant2ItemFilterV2Variant2FilterVariant1LogSource.Build => "build",
                GetAllLogDrainsResponseDrainsVariant2ItemFilterV2Variant2FilterVariant1LogSource.Edge => "edge",
                GetAllLogDrainsResponseDrainsVariant2ItemFilterV2Variant2FilterVariant1LogSource.External => "external",
                GetAllLogDrainsResponseDrainsVariant2ItemFilterV2Variant2FilterVariant1LogSource.Firewall => "firewall",
                GetAllLogDrainsResponseDrainsVariant2ItemFilterV2Variant2FilterVariant1LogSource.Lambda => "lambda",
                GetAllLogDrainsResponseDrainsVariant2ItemFilterV2Variant2FilterVariant1LogSource.Redirect => "redirect",
                GetAllLogDrainsResponseDrainsVariant2ItemFilterV2Variant2FilterVariant1LogSource.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAllLogDrainsResponseDrainsVariant2ItemFilterV2Variant2FilterVariant1LogSource? ToEnum(string value)
        {
            return value switch
            {
                "build" => GetAllLogDrainsResponseDrainsVariant2ItemFilterV2Variant2FilterVariant1LogSource.Build,
                "edge" => GetAllLogDrainsResponseDrainsVariant2ItemFilterV2Variant2FilterVariant1LogSource.Edge,
                "external" => GetAllLogDrainsResponseDrainsVariant2ItemFilterV2Variant2FilterVariant1LogSource.External,
                "firewall" => GetAllLogDrainsResponseDrainsVariant2ItemFilterV2Variant2FilterVariant1LogSource.Firewall,
                "lambda" => GetAllLogDrainsResponseDrainsVariant2ItemFilterV2Variant2FilterVariant1LogSource.Lambda,
                "redirect" => GetAllLogDrainsResponseDrainsVariant2ItemFilterV2Variant2FilterVariant1LogSource.Redirect,
                "static" => GetAllLogDrainsResponseDrainsVariant2ItemFilterV2Variant2FilterVariant1LogSource.Static,
                _ => null,
            };
        }
    }
}