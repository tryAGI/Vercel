
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Service kind (Service.type). Omitted for schemas that do not define one.
    /// </summary>
    public enum AutoSDKSharedc1c2f92d02e0feb6ServiceServiceType
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
    public static class AutoSDKSharedc1c2f92d02e0feb6ServiceServiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc1c2f92d02e0feb6ServiceServiceType value)
        {
            return value switch
            {
                AutoSDKSharedc1c2f92d02e0feb6ServiceServiceType.Cron => "cron",
                AutoSDKSharedc1c2f92d02e0feb6ServiceServiceType.Job => "job",
                AutoSDKSharedc1c2f92d02e0feb6ServiceServiceType.Web => "web",
                AutoSDKSharedc1c2f92d02e0feb6ServiceServiceType.Worker => "worker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc1c2f92d02e0feb6ServiceServiceType? ToEnum(string value)
        {
            return value switch
            {
                "cron" => AutoSDKSharedc1c2f92d02e0feb6ServiceServiceType.Cron,
                "job" => AutoSDKSharedc1c2f92d02e0feb6ServiceServiceType.Job,
                "web" => AutoSDKSharedc1c2f92d02e0feb6ServiceServiceType.Web,
                "worker" => AutoSDKSharedc1c2f92d02e0feb6ServiceServiceType.Worker,
                _ => null,
            };
        }
    }
}