
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The sources from which logs are currently being delivered to this log drain.<br/>
    /// Example: [build, edge]
    /// </summary>
    public enum GetIntegrationLogDrainsResponseItemSource
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
    public static class GetIntegrationLogDrainsResponseItemSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetIntegrationLogDrainsResponseItemSource value)
        {
            return value switch
            {
                GetIntegrationLogDrainsResponseItemSource.Build => "build",
                GetIntegrationLogDrainsResponseItemSource.Edge => "edge",
                GetIntegrationLogDrainsResponseItemSource.External => "external",
                GetIntegrationLogDrainsResponseItemSource.Firewall => "firewall",
                GetIntegrationLogDrainsResponseItemSource.Lambda => "lambda",
                GetIntegrationLogDrainsResponseItemSource.Redirect => "redirect",
                GetIntegrationLogDrainsResponseItemSource.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetIntegrationLogDrainsResponseItemSource? ToEnum(string value)
        {
            return value switch
            {
                "build" => GetIntegrationLogDrainsResponseItemSource.Build,
                "edge" => GetIntegrationLogDrainsResponseItemSource.Edge,
                "external" => GetIntegrationLogDrainsResponseItemSource.External,
                "firewall" => GetIntegrationLogDrainsResponseItemSource.Firewall,
                "lambda" => GetIntegrationLogDrainsResponseItemSource.Lambda,
                "redirect" => GetIntegrationLogDrainsResponseItemSource.Redirect,
                "static" => GetIntegrationLogDrainsResponseItemSource.Static,
                _ => null,
            };
        }
    }
}