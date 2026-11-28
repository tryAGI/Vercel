
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda3e211e8bee7aaa5FilterV2FilterVariant1LogSource
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
    public static class AutoSDKShareda3e211e8bee7aaa5FilterV2FilterVariant1LogSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda3e211e8bee7aaa5FilterV2FilterVariant1LogSource value)
        {
            return value switch
            {
                AutoSDKShareda3e211e8bee7aaa5FilterV2FilterVariant1LogSource.Build => "build",
                AutoSDKShareda3e211e8bee7aaa5FilterV2FilterVariant1LogSource.Edge => "edge",
                AutoSDKShareda3e211e8bee7aaa5FilterV2FilterVariant1LogSource.External => "external",
                AutoSDKShareda3e211e8bee7aaa5FilterV2FilterVariant1LogSource.Firewall => "firewall",
                AutoSDKShareda3e211e8bee7aaa5FilterV2FilterVariant1LogSource.Lambda => "lambda",
                AutoSDKShareda3e211e8bee7aaa5FilterV2FilterVariant1LogSource.Redirect => "redirect",
                AutoSDKShareda3e211e8bee7aaa5FilterV2FilterVariant1LogSource.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda3e211e8bee7aaa5FilterV2FilterVariant1LogSource? ToEnum(string value)
        {
            return value switch
            {
                "build" => AutoSDKShareda3e211e8bee7aaa5FilterV2FilterVariant1LogSource.Build,
                "edge" => AutoSDKShareda3e211e8bee7aaa5FilterV2FilterVariant1LogSource.Edge,
                "external" => AutoSDKShareda3e211e8bee7aaa5FilterV2FilterVariant1LogSource.External,
                "firewall" => AutoSDKShareda3e211e8bee7aaa5FilterV2FilterVariant1LogSource.Firewall,
                "lambda" => AutoSDKShareda3e211e8bee7aaa5FilterV2FilterVariant1LogSource.Lambda,
                "redirect" => AutoSDKShareda3e211e8bee7aaa5FilterV2FilterVariant1LogSource.Redirect,
                "static" => AutoSDKShareda3e211e8bee7aaa5FilterV2FilterVariant1LogSource.Static,
                _ => null,
            };
        }
    }
}