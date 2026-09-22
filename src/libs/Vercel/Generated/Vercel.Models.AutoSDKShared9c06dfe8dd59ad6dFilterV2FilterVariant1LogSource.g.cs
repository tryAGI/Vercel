
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared9c06dfe8dd59ad6dFilterV2FilterVariant1LogSource
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
    public static class AutoSDKShared9c06dfe8dd59ad6dFilterV2FilterVariant1LogSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared9c06dfe8dd59ad6dFilterV2FilterVariant1LogSource value)
        {
            return value switch
            {
                AutoSDKShared9c06dfe8dd59ad6dFilterV2FilterVariant1LogSource.Build => "build",
                AutoSDKShared9c06dfe8dd59ad6dFilterV2FilterVariant1LogSource.Edge => "edge",
                AutoSDKShared9c06dfe8dd59ad6dFilterV2FilterVariant1LogSource.External => "external",
                AutoSDKShared9c06dfe8dd59ad6dFilterV2FilterVariant1LogSource.Firewall => "firewall",
                AutoSDKShared9c06dfe8dd59ad6dFilterV2FilterVariant1LogSource.Lambda => "lambda",
                AutoSDKShared9c06dfe8dd59ad6dFilterV2FilterVariant1LogSource.Redirect => "redirect",
                AutoSDKShared9c06dfe8dd59ad6dFilterV2FilterVariant1LogSource.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared9c06dfe8dd59ad6dFilterV2FilterVariant1LogSource? ToEnum(string value)
        {
            return value switch
            {
                "build" => AutoSDKShared9c06dfe8dd59ad6dFilterV2FilterVariant1LogSource.Build,
                "edge" => AutoSDKShared9c06dfe8dd59ad6dFilterV2FilterVariant1LogSource.Edge,
                "external" => AutoSDKShared9c06dfe8dd59ad6dFilterV2FilterVariant1LogSource.External,
                "firewall" => AutoSDKShared9c06dfe8dd59ad6dFilterV2FilterVariant1LogSource.Firewall,
                "lambda" => AutoSDKShared9c06dfe8dd59ad6dFilterV2FilterVariant1LogSource.Lambda,
                "redirect" => AutoSDKShared9c06dfe8dd59ad6dFilterV2FilterVariant1LogSource.Redirect,
                "static" => AutoSDKShared9c06dfe8dd59ad6dFilterV2FilterVariant1LogSource.Static,
                _ => null,
            };
        }
    }
}