
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentEventsResponseItemVariant3Variant1PayloadProxyVercelCache
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
    public static class GetDeploymentEventsResponseItemVariant3Variant1PayloadProxyVercelCacheExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentEventsResponseItemVariant3Variant1PayloadProxyVercelCache value)
        {
            return value switch
            {
                GetDeploymentEventsResponseItemVariant3Variant1PayloadProxyVercelCache.Bypass => "BYPASS",
                GetDeploymentEventsResponseItemVariant3Variant1PayloadProxyVercelCache.Hit => "HIT",
                GetDeploymentEventsResponseItemVariant3Variant1PayloadProxyVercelCache.Miss => "MISS",
                GetDeploymentEventsResponseItemVariant3Variant1PayloadProxyVercelCache.Prerender => "PRERENDER",
                GetDeploymentEventsResponseItemVariant3Variant1PayloadProxyVercelCache.Revalidated => "REVALIDATED",
                GetDeploymentEventsResponseItemVariant3Variant1PayloadProxyVercelCache.Stale => "STALE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentEventsResponseItemVariant3Variant1PayloadProxyVercelCache? ToEnum(string value)
        {
            return value switch
            {
                "BYPASS" => GetDeploymentEventsResponseItemVariant3Variant1PayloadProxyVercelCache.Bypass,
                "HIT" => GetDeploymentEventsResponseItemVariant3Variant1PayloadProxyVercelCache.Hit,
                "MISS" => GetDeploymentEventsResponseItemVariant3Variant1PayloadProxyVercelCache.Miss,
                "PRERENDER" => GetDeploymentEventsResponseItemVariant3Variant1PayloadProxyVercelCache.Prerender,
                "REVALIDATED" => GetDeploymentEventsResponseItemVariant3Variant1PayloadProxyVercelCache.Revalidated,
                "STALE" => GetDeploymentEventsResponseItemVariant3Variant1PayloadProxyVercelCache.Stale,
                _ => null,
            };
        }
    }
}