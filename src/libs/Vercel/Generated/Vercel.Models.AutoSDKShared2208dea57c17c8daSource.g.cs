
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The sources from which logs are currently being delivered to this log drain.<br/>
    /// Example: [build, edge]
    /// </summary>
    public enum AutoSDKShared2208dea57c17c8daSource
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
    public static class AutoSDKShared2208dea57c17c8daSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared2208dea57c17c8daSource value)
        {
            return value switch
            {
                AutoSDKShared2208dea57c17c8daSource.Build => "build",
                AutoSDKShared2208dea57c17c8daSource.Edge => "edge",
                AutoSDKShared2208dea57c17c8daSource.External => "external",
                AutoSDKShared2208dea57c17c8daSource.Firewall => "firewall",
                AutoSDKShared2208dea57c17c8daSource.Lambda => "lambda",
                AutoSDKShared2208dea57c17c8daSource.Redirect => "redirect",
                AutoSDKShared2208dea57c17c8daSource.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared2208dea57c17c8daSource? ToEnum(string value)
        {
            return value switch
            {
                "build" => AutoSDKShared2208dea57c17c8daSource.Build,
                "edge" => AutoSDKShared2208dea57c17c8daSource.Edge,
                "external" => AutoSDKShared2208dea57c17c8daSource.External,
                "firewall" => AutoSDKShared2208dea57c17c8daSource.Firewall,
                "lambda" => AutoSDKShared2208dea57c17c8daSource.Lambda,
                "redirect" => AutoSDKShared2208dea57c17c8daSource.Redirect,
                "static" => AutoSDKShared2208dea57c17c8daSource.Static,
                _ => null,
            };
        }
    }
}