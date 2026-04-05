
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateConfigurableLogDrainRequestSource
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
        Static,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateConfigurableLogDrainRequestSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateConfigurableLogDrainRequestSource value)
        {
            return value switch
            {
                CreateConfigurableLogDrainRequestSource.Build => "build",
                CreateConfigurableLogDrainRequestSource.Edge => "edge",
                CreateConfigurableLogDrainRequestSource.External => "external",
                CreateConfigurableLogDrainRequestSource.Firewall => "firewall",
                CreateConfigurableLogDrainRequestSource.Lambda => "lambda",
                CreateConfigurableLogDrainRequestSource.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateConfigurableLogDrainRequestSource? ToEnum(string value)
        {
            return value switch
            {
                "build" => CreateConfigurableLogDrainRequestSource.Build,
                "edge" => CreateConfigurableLogDrainRequestSource.Edge,
                "external" => CreateConfigurableLogDrainRequestSource.External,
                "firewall" => CreateConfigurableLogDrainRequestSource.Firewall,
                "lambda" => CreateConfigurableLogDrainRequestSource.Lambda,
                "static" => CreateConfigurableLogDrainRequestSource.Static,
                _ => null,
            };
        }
    }
}