
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentEventsResponseItemVariant1PayloadProxyVercelCache
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
    public static class GetDeploymentEventsResponseItemVariant1PayloadProxyVercelCacheExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentEventsResponseItemVariant1PayloadProxyVercelCache value)
        {
            return value switch
            {
                GetDeploymentEventsResponseItemVariant1PayloadProxyVercelCache.Bypass => "BYPASS",
                GetDeploymentEventsResponseItemVariant1PayloadProxyVercelCache.Hit => "HIT",
                GetDeploymentEventsResponseItemVariant1PayloadProxyVercelCache.Miss => "MISS",
                GetDeploymentEventsResponseItemVariant1PayloadProxyVercelCache.Prerender => "PRERENDER",
                GetDeploymentEventsResponseItemVariant1PayloadProxyVercelCache.Revalidated => "REVALIDATED",
                GetDeploymentEventsResponseItemVariant1PayloadProxyVercelCache.Stale => "STALE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentEventsResponseItemVariant1PayloadProxyVercelCache? ToEnum(string value)
        {
            return value switch
            {
                "BYPASS" => GetDeploymentEventsResponseItemVariant1PayloadProxyVercelCache.Bypass,
                "HIT" => GetDeploymentEventsResponseItemVariant1PayloadProxyVercelCache.Hit,
                "MISS" => GetDeploymentEventsResponseItemVariant1PayloadProxyVercelCache.Miss,
                "PRERENDER" => GetDeploymentEventsResponseItemVariant1PayloadProxyVercelCache.Prerender,
                "REVALIDATED" => GetDeploymentEventsResponseItemVariant1PayloadProxyVercelCache.Revalidated,
                "STALE" => GetDeploymentEventsResponseItemVariant1PayloadProxyVercelCache.Stale,
                _ => null,
            };
        }
    }
}