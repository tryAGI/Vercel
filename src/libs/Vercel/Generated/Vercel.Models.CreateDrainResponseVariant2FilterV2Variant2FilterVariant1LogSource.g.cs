
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDrainResponseVariant2FilterV2Variant2FilterVariant1LogSource
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
    public static class CreateDrainResponseVariant2FilterV2Variant2FilterVariant1LogSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDrainResponseVariant2FilterV2Variant2FilterVariant1LogSource value)
        {
            return value switch
            {
                CreateDrainResponseVariant2FilterV2Variant2FilterVariant1LogSource.Build => "build",
                CreateDrainResponseVariant2FilterV2Variant2FilterVariant1LogSource.Edge => "edge",
                CreateDrainResponseVariant2FilterV2Variant2FilterVariant1LogSource.External => "external",
                CreateDrainResponseVariant2FilterV2Variant2FilterVariant1LogSource.Firewall => "firewall",
                CreateDrainResponseVariant2FilterV2Variant2FilterVariant1LogSource.Lambda => "lambda",
                CreateDrainResponseVariant2FilterV2Variant2FilterVariant1LogSource.Redirect => "redirect",
                CreateDrainResponseVariant2FilterV2Variant2FilterVariant1LogSource.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDrainResponseVariant2FilterV2Variant2FilterVariant1LogSource? ToEnum(string value)
        {
            return value switch
            {
                "build" => CreateDrainResponseVariant2FilterV2Variant2FilterVariant1LogSource.Build,
                "edge" => CreateDrainResponseVariant2FilterV2Variant2FilterVariant1LogSource.Edge,
                "external" => CreateDrainResponseVariant2FilterV2Variant2FilterVariant1LogSource.External,
                "firewall" => CreateDrainResponseVariant2FilterV2Variant2FilterVariant1LogSource.Firewall,
                "lambda" => CreateDrainResponseVariant2FilterV2Variant2FilterVariant1LogSource.Lambda,
                "redirect" => CreateDrainResponseVariant2FilterV2Variant2FilterVariant1LogSource.Redirect,
                "static" => CreateDrainResponseVariant2FilterV2Variant2FilterVariant1LogSource.Static,
                _ => null,
            };
        }
    }
}