
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDrainResponseVariant2FilterV2Variant2FilterVariant1LogSource
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
    public static class GetDrainResponseVariant2FilterV2Variant2FilterVariant1LogSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDrainResponseVariant2FilterV2Variant2FilterVariant1LogSource value)
        {
            return value switch
            {
                GetDrainResponseVariant2FilterV2Variant2FilterVariant1LogSource.Build => "build",
                GetDrainResponseVariant2FilterV2Variant2FilterVariant1LogSource.Edge => "edge",
                GetDrainResponseVariant2FilterV2Variant2FilterVariant1LogSource.External => "external",
                GetDrainResponseVariant2FilterV2Variant2FilterVariant1LogSource.Firewall => "firewall",
                GetDrainResponseVariant2FilterV2Variant2FilterVariant1LogSource.Lambda => "lambda",
                GetDrainResponseVariant2FilterV2Variant2FilterVariant1LogSource.Redirect => "redirect",
                GetDrainResponseVariant2FilterV2Variant2FilterVariant1LogSource.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDrainResponseVariant2FilterV2Variant2FilterVariant1LogSource? ToEnum(string value)
        {
            return value switch
            {
                "build" => GetDrainResponseVariant2FilterV2Variant2FilterVariant1LogSource.Build,
                "edge" => GetDrainResponseVariant2FilterV2Variant2FilterVariant1LogSource.Edge,
                "external" => GetDrainResponseVariant2FilterV2Variant2FilterVariant1LogSource.External,
                "firewall" => GetDrainResponseVariant2FilterV2Variant2FilterVariant1LogSource.Firewall,
                "lambda" => GetDrainResponseVariant2FilterV2Variant2FilterVariant1LogSource.Lambda,
                "redirect" => GetDrainResponseVariant2FilterV2Variant2FilterVariant1LogSource.Redirect,
                "static" => GetDrainResponseVariant2FilterV2Variant2FilterVariant1LogSource.Static,
                _ => null,
            };
        }
    }
}