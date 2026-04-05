
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentEventsResponseVariant1PayloadProxyVercelCache
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
    public static class GetDeploymentEventsResponseVariant1PayloadProxyVercelCacheExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentEventsResponseVariant1PayloadProxyVercelCache value)
        {
            return value switch
            {
                GetDeploymentEventsResponseVariant1PayloadProxyVercelCache.Bypass => "BYPASS",
                GetDeploymentEventsResponseVariant1PayloadProxyVercelCache.Hit => "HIT",
                GetDeploymentEventsResponseVariant1PayloadProxyVercelCache.Miss => "MISS",
                GetDeploymentEventsResponseVariant1PayloadProxyVercelCache.Prerender => "PRERENDER",
                GetDeploymentEventsResponseVariant1PayloadProxyVercelCache.Revalidated => "REVALIDATED",
                GetDeploymentEventsResponseVariant1PayloadProxyVercelCache.Stale => "STALE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentEventsResponseVariant1PayloadProxyVercelCache? ToEnum(string value)
        {
            return value switch
            {
                "BYPASS" => GetDeploymentEventsResponseVariant1PayloadProxyVercelCache.Bypass,
                "HIT" => GetDeploymentEventsResponseVariant1PayloadProxyVercelCache.Hit,
                "MISS" => GetDeploymentEventsResponseVariant1PayloadProxyVercelCache.Miss,
                "PRERENDER" => GetDeploymentEventsResponseVariant1PayloadProxyVercelCache.Prerender,
                "REVALIDATED" => GetDeploymentEventsResponseVariant1PayloadProxyVercelCache.Revalidated,
                "STALE" => GetDeploymentEventsResponseVariant1PayloadProxyVercelCache.Stale,
                _ => null,
            };
        }
    }
}