
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentEventsResponseVariant3Variant1PayloadProxyVercelCache
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
    public static class GetDeploymentEventsResponseVariant3Variant1PayloadProxyVercelCacheExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentEventsResponseVariant3Variant1PayloadProxyVercelCache value)
        {
            return value switch
            {
                GetDeploymentEventsResponseVariant3Variant1PayloadProxyVercelCache.Bypass => "BYPASS",
                GetDeploymentEventsResponseVariant3Variant1PayloadProxyVercelCache.Hit => "HIT",
                GetDeploymentEventsResponseVariant3Variant1PayloadProxyVercelCache.Miss => "MISS",
                GetDeploymentEventsResponseVariant3Variant1PayloadProxyVercelCache.Prerender => "PRERENDER",
                GetDeploymentEventsResponseVariant3Variant1PayloadProxyVercelCache.Revalidated => "REVALIDATED",
                GetDeploymentEventsResponseVariant3Variant1PayloadProxyVercelCache.Stale => "STALE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentEventsResponseVariant3Variant1PayloadProxyVercelCache? ToEnum(string value)
        {
            return value switch
            {
                "BYPASS" => GetDeploymentEventsResponseVariant3Variant1PayloadProxyVercelCache.Bypass,
                "HIT" => GetDeploymentEventsResponseVariant3Variant1PayloadProxyVercelCache.Hit,
                "MISS" => GetDeploymentEventsResponseVariant3Variant1PayloadProxyVercelCache.Miss,
                "PRERENDER" => GetDeploymentEventsResponseVariant3Variant1PayloadProxyVercelCache.Prerender,
                "REVALIDATED" => GetDeploymentEventsResponseVariant3Variant1PayloadProxyVercelCache.Revalidated,
                "STALE" => GetDeploymentEventsResponseVariant3Variant1PayloadProxyVercelCache.Stale,
                _ => null,
            };
        }
    }
}