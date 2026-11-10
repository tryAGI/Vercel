
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared8df5bff0bb4332b8FilterV2FilterVariant1LogSource
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
    public static class AutoSDKShared8df5bff0bb4332b8FilterV2FilterVariant1LogSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared8df5bff0bb4332b8FilterV2FilterVariant1LogSource value)
        {
            return value switch
            {
                AutoSDKShared8df5bff0bb4332b8FilterV2FilterVariant1LogSource.Build => "build",
                AutoSDKShared8df5bff0bb4332b8FilterV2FilterVariant1LogSource.Edge => "edge",
                AutoSDKShared8df5bff0bb4332b8FilterV2FilterVariant1LogSource.External => "external",
                AutoSDKShared8df5bff0bb4332b8FilterV2FilterVariant1LogSource.Firewall => "firewall",
                AutoSDKShared8df5bff0bb4332b8FilterV2FilterVariant1LogSource.Lambda => "lambda",
                AutoSDKShared8df5bff0bb4332b8FilterV2FilterVariant1LogSource.Redirect => "redirect",
                AutoSDKShared8df5bff0bb4332b8FilterV2FilterVariant1LogSource.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared8df5bff0bb4332b8FilterV2FilterVariant1LogSource? ToEnum(string value)
        {
            return value switch
            {
                "build" => AutoSDKShared8df5bff0bb4332b8FilterV2FilterVariant1LogSource.Build,
                "edge" => AutoSDKShared8df5bff0bb4332b8FilterV2FilterVariant1LogSource.Edge,
                "external" => AutoSDKShared8df5bff0bb4332b8FilterV2FilterVariant1LogSource.External,
                "firewall" => AutoSDKShared8df5bff0bb4332b8FilterV2FilterVariant1LogSource.Firewall,
                "lambda" => AutoSDKShared8df5bff0bb4332b8FilterV2FilterVariant1LogSource.Lambda,
                "redirect" => AutoSDKShared8df5bff0bb4332b8FilterV2FilterVariant1LogSource.Redirect,
                "static" => AutoSDKShared8df5bff0bb4332b8FilterV2FilterVariant1LogSource.Static,
                _ => null,
            };
        }
    }
}