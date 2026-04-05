
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateLogDrainRequestSource
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
    public static class CreateLogDrainRequestSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateLogDrainRequestSource value)
        {
            return value switch
            {
                CreateLogDrainRequestSource.Build => "build",
                CreateLogDrainRequestSource.Edge => "edge",
                CreateLogDrainRequestSource.External => "external",
                CreateLogDrainRequestSource.Firewall => "firewall",
                CreateLogDrainRequestSource.Lambda => "lambda",
                CreateLogDrainRequestSource.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateLogDrainRequestSource? ToEnum(string value)
        {
            return value switch
            {
                "build" => CreateLogDrainRequestSource.Build,
                "edge" => CreateLogDrainRequestSource.Edge,
                "external" => CreateLogDrainRequestSource.External,
                "firewall" => CreateLogDrainRequestSource.Firewall,
                "lambda" => CreateLogDrainRequestSource.Lambda,
                "static" => CreateLogDrainRequestSource.Static,
                _ => null,
            };
        }
    }
}