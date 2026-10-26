
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Service kind (Service.type). Omitted for schemas that do not define one.
    /// </summary>
    public enum AutoSDKShared8b163ed62d2bb341ServiceServiceType
    {
        /// <summary>
        ///
        /// </summary>
        Cron,
        /// <summary>
        ///
        /// </summary>
        Job,
        /// <summary>
        ///
        /// </summary>
        Web,
        /// <summary>
        ///
        /// </summary>
        Worker,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared8b163ed62d2bb341ServiceServiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared8b163ed62d2bb341ServiceServiceType value)
        {
            return value switch
            {
                AutoSDKShared8b163ed62d2bb341ServiceServiceType.Cron => "cron",
                AutoSDKShared8b163ed62d2bb341ServiceServiceType.Job => "job",
                AutoSDKShared8b163ed62d2bb341ServiceServiceType.Web => "web",
                AutoSDKShared8b163ed62d2bb341ServiceServiceType.Worker => "worker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared8b163ed62d2bb341ServiceServiceType? ToEnum(string value)
        {
            return value switch
            {
                "cron" => AutoSDKShared8b163ed62d2bb341ServiceServiceType.Cron,
                "job" => AutoSDKShared8b163ed62d2bb341ServiceServiceType.Job,
                "web" => AutoSDKShared8b163ed62d2bb341ServiceServiceType.Web,
                "worker" => AutoSDKShared8b163ed62d2bb341ServiceServiceType.Worker,
                _ => null,
            };
        }
    }
}