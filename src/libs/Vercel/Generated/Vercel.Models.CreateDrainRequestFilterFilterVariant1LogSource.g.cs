
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDrainRequestFilterFilterVariant1LogSource
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
    public static class CreateDrainRequestFilterFilterVariant1LogSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDrainRequestFilterFilterVariant1LogSource value)
        {
            return value switch
            {
                CreateDrainRequestFilterFilterVariant1LogSource.Build => "build",
                CreateDrainRequestFilterFilterVariant1LogSource.Edge => "edge",
                CreateDrainRequestFilterFilterVariant1LogSource.External => "external",
                CreateDrainRequestFilterFilterVariant1LogSource.Firewall => "firewall",
                CreateDrainRequestFilterFilterVariant1LogSource.Lambda => "lambda",
                CreateDrainRequestFilterFilterVariant1LogSource.Redirect => "redirect",
                CreateDrainRequestFilterFilterVariant1LogSource.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDrainRequestFilterFilterVariant1LogSource? ToEnum(string value)
        {
            return value switch
            {
                "build" => CreateDrainRequestFilterFilterVariant1LogSource.Build,
                "edge" => CreateDrainRequestFilterFilterVariant1LogSource.Edge,
                "external" => CreateDrainRequestFilterFilterVariant1LogSource.External,
                "firewall" => CreateDrainRequestFilterFilterVariant1LogSource.Firewall,
                "lambda" => CreateDrainRequestFilterFilterVariant1LogSource.Lambda,
                "redirect" => CreateDrainRequestFilterFilterVariant1LogSource.Redirect,
                "static" => CreateDrainRequestFilterFilterVariant1LogSource.Static,
                _ => null,
            };
        }
    }
}