
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda861c3cb40ec56dcFilterV2FilterVariant1LogSource
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
    public static class AutoSDKShareda861c3cb40ec56dcFilterV2FilterVariant1LogSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda861c3cb40ec56dcFilterV2FilterVariant1LogSource value)
        {
            return value switch
            {
                AutoSDKShareda861c3cb40ec56dcFilterV2FilterVariant1LogSource.Build => "build",
                AutoSDKShareda861c3cb40ec56dcFilterV2FilterVariant1LogSource.Edge => "edge",
                AutoSDKShareda861c3cb40ec56dcFilterV2FilterVariant1LogSource.External => "external",
                AutoSDKShareda861c3cb40ec56dcFilterV2FilterVariant1LogSource.Firewall => "firewall",
                AutoSDKShareda861c3cb40ec56dcFilterV2FilterVariant1LogSource.Lambda => "lambda",
                AutoSDKShareda861c3cb40ec56dcFilterV2FilterVariant1LogSource.Redirect => "redirect",
                AutoSDKShareda861c3cb40ec56dcFilterV2FilterVariant1LogSource.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda861c3cb40ec56dcFilterV2FilterVariant1LogSource? ToEnum(string value)
        {
            return value switch
            {
                "build" => AutoSDKShareda861c3cb40ec56dcFilterV2FilterVariant1LogSource.Build,
                "edge" => AutoSDKShareda861c3cb40ec56dcFilterV2FilterVariant1LogSource.Edge,
                "external" => AutoSDKShareda861c3cb40ec56dcFilterV2FilterVariant1LogSource.External,
                "firewall" => AutoSDKShareda861c3cb40ec56dcFilterV2FilterVariant1LogSource.Firewall,
                "lambda" => AutoSDKShareda861c3cb40ec56dcFilterV2FilterVariant1LogSource.Lambda,
                "redirect" => AutoSDKShareda861c3cb40ec56dcFilterV2FilterVariant1LogSource.Redirect,
                "static" => AutoSDKShareda861c3cb40ec56dcFilterV2FilterVariant1LogSource.Static,
                _ => null,
            };
        }
    }
}