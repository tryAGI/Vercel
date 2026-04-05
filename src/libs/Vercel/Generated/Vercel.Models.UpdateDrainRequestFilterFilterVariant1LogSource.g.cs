
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateDrainRequestFilterFilterVariant1LogSource
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
    public static class UpdateDrainRequestFilterFilterVariant1LogSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDrainRequestFilterFilterVariant1LogSource value)
        {
            return value switch
            {
                UpdateDrainRequestFilterFilterVariant1LogSource.Build => "build",
                UpdateDrainRequestFilterFilterVariant1LogSource.Edge => "edge",
                UpdateDrainRequestFilterFilterVariant1LogSource.External => "external",
                UpdateDrainRequestFilterFilterVariant1LogSource.Firewall => "firewall",
                UpdateDrainRequestFilterFilterVariant1LogSource.Lambda => "lambda",
                UpdateDrainRequestFilterFilterVariant1LogSource.Redirect => "redirect",
                UpdateDrainRequestFilterFilterVariant1LogSource.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDrainRequestFilterFilterVariant1LogSource? ToEnum(string value)
        {
            return value switch
            {
                "build" => UpdateDrainRequestFilterFilterVariant1LogSource.Build,
                "edge" => UpdateDrainRequestFilterFilterVariant1LogSource.Edge,
                "external" => UpdateDrainRequestFilterFilterVariant1LogSource.External,
                "firewall" => UpdateDrainRequestFilterFilterVariant1LogSource.Firewall,
                "lambda" => UpdateDrainRequestFilterFilterVariant1LogSource.Lambda,
                "redirect" => UpdateDrainRequestFilterFilterVariant1LogSource.Redirect,
                "static" => UpdateDrainRequestFilterFilterVariant1LogSource.Static,
                _ => null,
            };
        }
    }
}