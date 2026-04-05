
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The sources from which logs are currently being delivered to this log drain.<br/>
    /// Example: [build, edge]
    /// </summary>
    public enum CreateLogDrainResponseSource
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
    public static class CreateLogDrainResponseSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateLogDrainResponseSource value)
        {
            return value switch
            {
                CreateLogDrainResponseSource.Build => "build",
                CreateLogDrainResponseSource.Edge => "edge",
                CreateLogDrainResponseSource.External => "external",
                CreateLogDrainResponseSource.Firewall => "firewall",
                CreateLogDrainResponseSource.Lambda => "lambda",
                CreateLogDrainResponseSource.Redirect => "redirect",
                CreateLogDrainResponseSource.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateLogDrainResponseSource? ToEnum(string value)
        {
            return value switch
            {
                "build" => CreateLogDrainResponseSource.Build,
                "edge" => CreateLogDrainResponseSource.Edge,
                "external" => CreateLogDrainResponseSource.External,
                "firewall" => CreateLogDrainResponseSource.Firewall,
                "lambda" => CreateLogDrainResponseSource.Lambda,
                "redirect" => CreateLogDrainResponseSource.Redirect,
                "static" => CreateLogDrainResponseSource.Static,
                _ => null,
            };
        }
    }
}