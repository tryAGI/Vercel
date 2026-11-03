
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedd5d6c9ab94c25f66FilterV2FilterVariant1LogSource
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
    public static class AutoSDKSharedd5d6c9ab94c25f66FilterV2FilterVariant1LogSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedd5d6c9ab94c25f66FilterV2FilterVariant1LogSource value)
        {
            return value switch
            {
                AutoSDKSharedd5d6c9ab94c25f66FilterV2FilterVariant1LogSource.Build => "build",
                AutoSDKSharedd5d6c9ab94c25f66FilterV2FilterVariant1LogSource.Edge => "edge",
                AutoSDKSharedd5d6c9ab94c25f66FilterV2FilterVariant1LogSource.External => "external",
                AutoSDKSharedd5d6c9ab94c25f66FilterV2FilterVariant1LogSource.Firewall => "firewall",
                AutoSDKSharedd5d6c9ab94c25f66FilterV2FilterVariant1LogSource.Lambda => "lambda",
                AutoSDKSharedd5d6c9ab94c25f66FilterV2FilterVariant1LogSource.Redirect => "redirect",
                AutoSDKSharedd5d6c9ab94c25f66FilterV2FilterVariant1LogSource.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedd5d6c9ab94c25f66FilterV2FilterVariant1LogSource? ToEnum(string value)
        {
            return value switch
            {
                "build" => AutoSDKSharedd5d6c9ab94c25f66FilterV2FilterVariant1LogSource.Build,
                "edge" => AutoSDKSharedd5d6c9ab94c25f66FilterV2FilterVariant1LogSource.Edge,
                "external" => AutoSDKSharedd5d6c9ab94c25f66FilterV2FilterVariant1LogSource.External,
                "firewall" => AutoSDKSharedd5d6c9ab94c25f66FilterV2FilterVariant1LogSource.Firewall,
                "lambda" => AutoSDKSharedd5d6c9ab94c25f66FilterV2FilterVariant1LogSource.Lambda,
                "redirect" => AutoSDKSharedd5d6c9ab94c25f66FilterV2FilterVariant1LogSource.Redirect,
                "static" => AutoSDKSharedd5d6c9ab94c25f66FilterV2FilterVariant1LogSource.Static,
                _ => null,
            };
        }
    }
}