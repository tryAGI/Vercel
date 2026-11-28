
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared2b02cf1378da97a7FilterV2FilterVariant1LogSource
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
    public static class AutoSDKShared2b02cf1378da97a7FilterV2FilterVariant1LogSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared2b02cf1378da97a7FilterV2FilterVariant1LogSource value)
        {
            return value switch
            {
                AutoSDKShared2b02cf1378da97a7FilterV2FilterVariant1LogSource.Build => "build",
                AutoSDKShared2b02cf1378da97a7FilterV2FilterVariant1LogSource.Edge => "edge",
                AutoSDKShared2b02cf1378da97a7FilterV2FilterVariant1LogSource.External => "external",
                AutoSDKShared2b02cf1378da97a7FilterV2FilterVariant1LogSource.Firewall => "firewall",
                AutoSDKShared2b02cf1378da97a7FilterV2FilterVariant1LogSource.Lambda => "lambda",
                AutoSDKShared2b02cf1378da97a7FilterV2FilterVariant1LogSource.Redirect => "redirect",
                AutoSDKShared2b02cf1378da97a7FilterV2FilterVariant1LogSource.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared2b02cf1378da97a7FilterV2FilterVariant1LogSource? ToEnum(string value)
        {
            return value switch
            {
                "build" => AutoSDKShared2b02cf1378da97a7FilterV2FilterVariant1LogSource.Build,
                "edge" => AutoSDKShared2b02cf1378da97a7FilterV2FilterVariant1LogSource.Edge,
                "external" => AutoSDKShared2b02cf1378da97a7FilterV2FilterVariant1LogSource.External,
                "firewall" => AutoSDKShared2b02cf1378da97a7FilterV2FilterVariant1LogSource.Firewall,
                "lambda" => AutoSDKShared2b02cf1378da97a7FilterV2FilterVariant1LogSource.Lambda,
                "redirect" => AutoSDKShared2b02cf1378da97a7FilterV2FilterVariant1LogSource.Redirect,
                "static" => AutoSDKShared2b02cf1378da97a7FilterV2FilterVariant1LogSource.Static,
                _ => null,
            };
        }
    }
}