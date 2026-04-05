
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDrainResponseVariant1FilterV2Variant2FilterVariant1LogSource
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
    public static class CreateDrainResponseVariant1FilterV2Variant2FilterVariant1LogSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDrainResponseVariant1FilterV2Variant2FilterVariant1LogSource value)
        {
            return value switch
            {
                CreateDrainResponseVariant1FilterV2Variant2FilterVariant1LogSource.Build => "build",
                CreateDrainResponseVariant1FilterV2Variant2FilterVariant1LogSource.Edge => "edge",
                CreateDrainResponseVariant1FilterV2Variant2FilterVariant1LogSource.External => "external",
                CreateDrainResponseVariant1FilterV2Variant2FilterVariant1LogSource.Firewall => "firewall",
                CreateDrainResponseVariant1FilterV2Variant2FilterVariant1LogSource.Lambda => "lambda",
                CreateDrainResponseVariant1FilterV2Variant2FilterVariant1LogSource.Redirect => "redirect",
                CreateDrainResponseVariant1FilterV2Variant2FilterVariant1LogSource.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDrainResponseVariant1FilterV2Variant2FilterVariant1LogSource? ToEnum(string value)
        {
            return value switch
            {
                "build" => CreateDrainResponseVariant1FilterV2Variant2FilterVariant1LogSource.Build,
                "edge" => CreateDrainResponseVariant1FilterV2Variant2FilterVariant1LogSource.Edge,
                "external" => CreateDrainResponseVariant1FilterV2Variant2FilterVariant1LogSource.External,
                "firewall" => CreateDrainResponseVariant1FilterV2Variant2FilterVariant1LogSource.Firewall,
                "lambda" => CreateDrainResponseVariant1FilterV2Variant2FilterVariant1LogSource.Lambda,
                "redirect" => CreateDrainResponseVariant1FilterV2Variant2FilterVariant1LogSource.Redirect,
                "static" => CreateDrainResponseVariant1FilterV2Variant2FilterVariant1LogSource.Static,
                _ => null,
            };
        }
    }
}