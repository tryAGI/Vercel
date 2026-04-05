
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateDrainResponseVariant2FilterV2Variant2FilterVariant1LogSource
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
    public static class UpdateDrainResponseVariant2FilterV2Variant2FilterVariant1LogSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDrainResponseVariant2FilterV2Variant2FilterVariant1LogSource value)
        {
            return value switch
            {
                UpdateDrainResponseVariant2FilterV2Variant2FilterVariant1LogSource.Build => "build",
                UpdateDrainResponseVariant2FilterV2Variant2FilterVariant1LogSource.Edge => "edge",
                UpdateDrainResponseVariant2FilterV2Variant2FilterVariant1LogSource.External => "external",
                UpdateDrainResponseVariant2FilterV2Variant2FilterVariant1LogSource.Firewall => "firewall",
                UpdateDrainResponseVariant2FilterV2Variant2FilterVariant1LogSource.Lambda => "lambda",
                UpdateDrainResponseVariant2FilterV2Variant2FilterVariant1LogSource.Redirect => "redirect",
                UpdateDrainResponseVariant2FilterV2Variant2FilterVariant1LogSource.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDrainResponseVariant2FilterV2Variant2FilterVariant1LogSource? ToEnum(string value)
        {
            return value switch
            {
                "build" => UpdateDrainResponseVariant2FilterV2Variant2FilterVariant1LogSource.Build,
                "edge" => UpdateDrainResponseVariant2FilterV2Variant2FilterVariant1LogSource.Edge,
                "external" => UpdateDrainResponseVariant2FilterV2Variant2FilterVariant1LogSource.External,
                "firewall" => UpdateDrainResponseVariant2FilterV2Variant2FilterVariant1LogSource.Firewall,
                "lambda" => UpdateDrainResponseVariant2FilterV2Variant2FilterVariant1LogSource.Lambda,
                "redirect" => UpdateDrainResponseVariant2FilterV2Variant2FilterVariant1LogSource.Redirect,
                "static" => UpdateDrainResponseVariant2FilterV2Variant2FilterVariant1LogSource.Static,
                _ => null,
            };
        }
    }
}