
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The sources from which logs are currently being delivered to this log drain.<br/>
    /// Example: [build, edge]
    /// </summary>
    public enum AutoSDKSharedc396e89a7a8d84fbSource
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
    public static class AutoSDKSharedc396e89a7a8d84fbSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc396e89a7a8d84fbSource value)
        {
            return value switch
            {
                AutoSDKSharedc396e89a7a8d84fbSource.Build => "build",
                AutoSDKSharedc396e89a7a8d84fbSource.Edge => "edge",
                AutoSDKSharedc396e89a7a8d84fbSource.External => "external",
                AutoSDKSharedc396e89a7a8d84fbSource.Firewall => "firewall",
                AutoSDKSharedc396e89a7a8d84fbSource.Lambda => "lambda",
                AutoSDKSharedc396e89a7a8d84fbSource.Redirect => "redirect",
                AutoSDKSharedc396e89a7a8d84fbSource.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc396e89a7a8d84fbSource? ToEnum(string value)
        {
            return value switch
            {
                "build" => AutoSDKSharedc396e89a7a8d84fbSource.Build,
                "edge" => AutoSDKSharedc396e89a7a8d84fbSource.Edge,
                "external" => AutoSDKSharedc396e89a7a8d84fbSource.External,
                "firewall" => AutoSDKSharedc396e89a7a8d84fbSource.Firewall,
                "lambda" => AutoSDKSharedc396e89a7a8d84fbSource.Lambda,
                "redirect" => AutoSDKSharedc396e89a7a8d84fbSource.Redirect,
                "static" => AutoSDKSharedc396e89a7a8d84fbSource.Static,
                _ => null,
            };
        }
    }
}