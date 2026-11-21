
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedcf426121243a64beVariant1PayloadProxyVercelCache
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
    public static class AutoSDKSharedcf426121243a64beVariant1PayloadProxyVercelCacheExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedcf426121243a64beVariant1PayloadProxyVercelCache value)
        {
            return value switch
            {
                AutoSDKSharedcf426121243a64beVariant1PayloadProxyVercelCache.Bypass => "BYPASS",
                AutoSDKSharedcf426121243a64beVariant1PayloadProxyVercelCache.Hit => "HIT",
                AutoSDKSharedcf426121243a64beVariant1PayloadProxyVercelCache.Miss => "MISS",
                AutoSDKSharedcf426121243a64beVariant1PayloadProxyVercelCache.Prerender => "PRERENDER",
                AutoSDKSharedcf426121243a64beVariant1PayloadProxyVercelCache.Revalidated => "REVALIDATED",
                AutoSDKSharedcf426121243a64beVariant1PayloadProxyVercelCache.Stale => "STALE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedcf426121243a64beVariant1PayloadProxyVercelCache? ToEnum(string value)
        {
            return value switch
            {
                "BYPASS" => AutoSDKSharedcf426121243a64beVariant1PayloadProxyVercelCache.Bypass,
                "HIT" => AutoSDKSharedcf426121243a64beVariant1PayloadProxyVercelCache.Hit,
                "MISS" => AutoSDKSharedcf426121243a64beVariant1PayloadProxyVercelCache.Miss,
                "PRERENDER" => AutoSDKSharedcf426121243a64beVariant1PayloadProxyVercelCache.Prerender,
                "REVALIDATED" => AutoSDKSharedcf426121243a64beVariant1PayloadProxyVercelCache.Revalidated,
                "STALE" => AutoSDKSharedcf426121243a64beVariant1PayloadProxyVercelCache.Stale,
                _ => null,
            };
        }
    }
}