
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared56f06376e757011bFilterV2FilterVariant1LogSource
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
    public static class AutoSDKShared56f06376e757011bFilterV2FilterVariant1LogSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared56f06376e757011bFilterV2FilterVariant1LogSource value)
        {
            return value switch
            {
                AutoSDKShared56f06376e757011bFilterV2FilterVariant1LogSource.Build => "build",
                AutoSDKShared56f06376e757011bFilterV2FilterVariant1LogSource.Edge => "edge",
                AutoSDKShared56f06376e757011bFilterV2FilterVariant1LogSource.External => "external",
                AutoSDKShared56f06376e757011bFilterV2FilterVariant1LogSource.Firewall => "firewall",
                AutoSDKShared56f06376e757011bFilterV2FilterVariant1LogSource.Lambda => "lambda",
                AutoSDKShared56f06376e757011bFilterV2FilterVariant1LogSource.Redirect => "redirect",
                AutoSDKShared56f06376e757011bFilterV2FilterVariant1LogSource.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared56f06376e757011bFilterV2FilterVariant1LogSource? ToEnum(string value)
        {
            return value switch
            {
                "build" => AutoSDKShared56f06376e757011bFilterV2FilterVariant1LogSource.Build,
                "edge" => AutoSDKShared56f06376e757011bFilterV2FilterVariant1LogSource.Edge,
                "external" => AutoSDKShared56f06376e757011bFilterV2FilterVariant1LogSource.External,
                "firewall" => AutoSDKShared56f06376e757011bFilterV2FilterVariant1LogSource.Firewall,
                "lambda" => AutoSDKShared56f06376e757011bFilterV2FilterVariant1LogSource.Lambda,
                "redirect" => AutoSDKShared56f06376e757011bFilterV2FilterVariant1LogSource.Redirect,
                "static" => AutoSDKShared56f06376e757011bFilterV2FilterVariant1LogSource.Static,
                _ => null,
            };
        }
    }
}