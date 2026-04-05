
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateDrainResponseVariant1FilterV2Variant2FilterVariant1LogSource
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
    public static class UpdateDrainResponseVariant1FilterV2Variant2FilterVariant1LogSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDrainResponseVariant1FilterV2Variant2FilterVariant1LogSource value)
        {
            return value switch
            {
                UpdateDrainResponseVariant1FilterV2Variant2FilterVariant1LogSource.Build => "build",
                UpdateDrainResponseVariant1FilterV2Variant2FilterVariant1LogSource.Edge => "edge",
                UpdateDrainResponseVariant1FilterV2Variant2FilterVariant1LogSource.External => "external",
                UpdateDrainResponseVariant1FilterV2Variant2FilterVariant1LogSource.Firewall => "firewall",
                UpdateDrainResponseVariant1FilterV2Variant2FilterVariant1LogSource.Lambda => "lambda",
                UpdateDrainResponseVariant1FilterV2Variant2FilterVariant1LogSource.Redirect => "redirect",
                UpdateDrainResponseVariant1FilterV2Variant2FilterVariant1LogSource.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDrainResponseVariant1FilterV2Variant2FilterVariant1LogSource? ToEnum(string value)
        {
            return value switch
            {
                "build" => UpdateDrainResponseVariant1FilterV2Variant2FilterVariant1LogSource.Build,
                "edge" => UpdateDrainResponseVariant1FilterV2Variant2FilterVariant1LogSource.Edge,
                "external" => UpdateDrainResponseVariant1FilterV2Variant2FilterVariant1LogSource.External,
                "firewall" => UpdateDrainResponseVariant1FilterV2Variant2FilterVariant1LogSource.Firewall,
                "lambda" => UpdateDrainResponseVariant1FilterV2Variant2FilterVariant1LogSource.Lambda,
                "redirect" => UpdateDrainResponseVariant1FilterV2Variant2FilterVariant1LogSource.Redirect,
                "static" => UpdateDrainResponseVariant1FilterV2Variant2FilterVariant1LogSource.Static,
                _ => null,
            };
        }
    }
}