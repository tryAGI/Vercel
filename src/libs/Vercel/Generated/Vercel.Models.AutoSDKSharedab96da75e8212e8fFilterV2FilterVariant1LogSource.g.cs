
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedab96da75e8212e8fFilterV2FilterVariant1LogSource
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
    public static class AutoSDKSharedab96da75e8212e8fFilterV2FilterVariant1LogSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedab96da75e8212e8fFilterV2FilterVariant1LogSource value)
        {
            return value switch
            {
                AutoSDKSharedab96da75e8212e8fFilterV2FilterVariant1LogSource.Build => "build",
                AutoSDKSharedab96da75e8212e8fFilterV2FilterVariant1LogSource.Edge => "edge",
                AutoSDKSharedab96da75e8212e8fFilterV2FilterVariant1LogSource.External => "external",
                AutoSDKSharedab96da75e8212e8fFilterV2FilterVariant1LogSource.Firewall => "firewall",
                AutoSDKSharedab96da75e8212e8fFilterV2FilterVariant1LogSource.Lambda => "lambda",
                AutoSDKSharedab96da75e8212e8fFilterV2FilterVariant1LogSource.Redirect => "redirect",
                AutoSDKSharedab96da75e8212e8fFilterV2FilterVariant1LogSource.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedab96da75e8212e8fFilterV2FilterVariant1LogSource? ToEnum(string value)
        {
            return value switch
            {
                "build" => AutoSDKSharedab96da75e8212e8fFilterV2FilterVariant1LogSource.Build,
                "edge" => AutoSDKSharedab96da75e8212e8fFilterV2FilterVariant1LogSource.Edge,
                "external" => AutoSDKSharedab96da75e8212e8fFilterV2FilterVariant1LogSource.External,
                "firewall" => AutoSDKSharedab96da75e8212e8fFilterV2FilterVariant1LogSource.Firewall,
                "lambda" => AutoSDKSharedab96da75e8212e8fFilterV2FilterVariant1LogSource.Lambda,
                "redirect" => AutoSDKSharedab96da75e8212e8fFilterV2FilterVariant1LogSource.Redirect,
                "static" => AutoSDKSharedab96da75e8212e8fFilterV2FilterVariant1LogSource.Static,
                _ => null,
            };
        }
    }
}