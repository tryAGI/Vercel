
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDrainResponseVariant1FilterV2Variant2FilterVariant1LogSource
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
    public static class GetDrainResponseVariant1FilterV2Variant2FilterVariant1LogSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDrainResponseVariant1FilterV2Variant2FilterVariant1LogSource value)
        {
            return value switch
            {
                GetDrainResponseVariant1FilterV2Variant2FilterVariant1LogSource.Build => "build",
                GetDrainResponseVariant1FilterV2Variant2FilterVariant1LogSource.Edge => "edge",
                GetDrainResponseVariant1FilterV2Variant2FilterVariant1LogSource.External => "external",
                GetDrainResponseVariant1FilterV2Variant2FilterVariant1LogSource.Firewall => "firewall",
                GetDrainResponseVariant1FilterV2Variant2FilterVariant1LogSource.Lambda => "lambda",
                GetDrainResponseVariant1FilterV2Variant2FilterVariant1LogSource.Redirect => "redirect",
                GetDrainResponseVariant1FilterV2Variant2FilterVariant1LogSource.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDrainResponseVariant1FilterV2Variant2FilterVariant1LogSource? ToEnum(string value)
        {
            return value switch
            {
                "build" => GetDrainResponseVariant1FilterV2Variant2FilterVariant1LogSource.Build,
                "edge" => GetDrainResponseVariant1FilterV2Variant2FilterVariant1LogSource.Edge,
                "external" => GetDrainResponseVariant1FilterV2Variant2FilterVariant1LogSource.External,
                "firewall" => GetDrainResponseVariant1FilterV2Variant2FilterVariant1LogSource.Firewall,
                "lambda" => GetDrainResponseVariant1FilterV2Variant2FilterVariant1LogSource.Lambda,
                "redirect" => GetDrainResponseVariant1FilterV2Variant2FilterVariant1LogSource.Redirect,
                "static" => GetDrainResponseVariant1FilterV2Variant2FilterVariant1LogSource.Static,
                _ => null,
            };
        }
    }
}