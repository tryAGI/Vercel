
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedbd3f01cc8f6abd3dVariant1PayloadProxyVercelCache
    {
        /// <summary>
        ///
        /// </summary>
        Bypass,
        /// <summary>
        ///
        /// </summary>
        Hit,
        /// <summary>
        ///
        /// </summary>
        Miss,
        /// <summary>
        ///
        /// </summary>
        Prerender,
        /// <summary>
        ///
        /// </summary>
        Revalidated,
        /// <summary>
        ///
        /// </summary>
        Stale,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedbd3f01cc8f6abd3dVariant1PayloadProxyVercelCacheExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedbd3f01cc8f6abd3dVariant1PayloadProxyVercelCache value)
        {
            return value switch
            {
                AutoSDKSharedbd3f01cc8f6abd3dVariant1PayloadProxyVercelCache.Bypass => "BYPASS",
                AutoSDKSharedbd3f01cc8f6abd3dVariant1PayloadProxyVercelCache.Hit => "HIT",
                AutoSDKSharedbd3f01cc8f6abd3dVariant1PayloadProxyVercelCache.Miss => "MISS",
                AutoSDKSharedbd3f01cc8f6abd3dVariant1PayloadProxyVercelCache.Prerender => "PRERENDER",
                AutoSDKSharedbd3f01cc8f6abd3dVariant1PayloadProxyVercelCache.Revalidated => "REVALIDATED",
                AutoSDKSharedbd3f01cc8f6abd3dVariant1PayloadProxyVercelCache.Stale => "STALE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedbd3f01cc8f6abd3dVariant1PayloadProxyVercelCache? ToEnum(string value)
        {
            return value switch
            {
                "BYPASS" => AutoSDKSharedbd3f01cc8f6abd3dVariant1PayloadProxyVercelCache.Bypass,
                "HIT" => AutoSDKSharedbd3f01cc8f6abd3dVariant1PayloadProxyVercelCache.Hit,
                "MISS" => AutoSDKSharedbd3f01cc8f6abd3dVariant1PayloadProxyVercelCache.Miss,
                "PRERENDER" => AutoSDKSharedbd3f01cc8f6abd3dVariant1PayloadProxyVercelCache.Prerender,
                "REVALIDATED" => AutoSDKSharedbd3f01cc8f6abd3dVariant1PayloadProxyVercelCache.Revalidated,
                "STALE" => AutoSDKSharedbd3f01cc8f6abd3dVariant1PayloadProxyVercelCache.Stale,
                _ => null,
            };
        }
    }
}