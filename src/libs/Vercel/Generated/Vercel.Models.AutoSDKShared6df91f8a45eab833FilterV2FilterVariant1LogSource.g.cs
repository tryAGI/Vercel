
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6df91f8a45eab833FilterV2FilterVariant1LogSource
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
    public static class AutoSDKShared6df91f8a45eab833FilterV2FilterVariant1LogSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6df91f8a45eab833FilterV2FilterVariant1LogSource value)
        {
            return value switch
            {
                AutoSDKShared6df91f8a45eab833FilterV2FilterVariant1LogSource.Build => "build",
                AutoSDKShared6df91f8a45eab833FilterV2FilterVariant1LogSource.Edge => "edge",
                AutoSDKShared6df91f8a45eab833FilterV2FilterVariant1LogSource.External => "external",
                AutoSDKShared6df91f8a45eab833FilterV2FilterVariant1LogSource.Firewall => "firewall",
                AutoSDKShared6df91f8a45eab833FilterV2FilterVariant1LogSource.Lambda => "lambda",
                AutoSDKShared6df91f8a45eab833FilterV2FilterVariant1LogSource.Redirect => "redirect",
                AutoSDKShared6df91f8a45eab833FilterV2FilterVariant1LogSource.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6df91f8a45eab833FilterV2FilterVariant1LogSource? ToEnum(string value)
        {
            return value switch
            {
                "build" => AutoSDKShared6df91f8a45eab833FilterV2FilterVariant1LogSource.Build,
                "edge" => AutoSDKShared6df91f8a45eab833FilterV2FilterVariant1LogSource.Edge,
                "external" => AutoSDKShared6df91f8a45eab833FilterV2FilterVariant1LogSource.External,
                "firewall" => AutoSDKShared6df91f8a45eab833FilterV2FilterVariant1LogSource.Firewall,
                "lambda" => AutoSDKShared6df91f8a45eab833FilterV2FilterVariant1LogSource.Lambda,
                "redirect" => AutoSDKShared6df91f8a45eab833FilterV2FilterVariant1LogSource.Redirect,
                "static" => AutoSDKShared6df91f8a45eab833FilterV2FilterVariant1LogSource.Static,
                _ => null,
            };
        }
    }
}