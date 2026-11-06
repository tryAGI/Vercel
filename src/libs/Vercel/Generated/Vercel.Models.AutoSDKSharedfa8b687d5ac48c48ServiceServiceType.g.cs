
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Service kind (Service.type). Omitted for schemas that do not define one.
    /// </summary>
    public enum AutoSDKSharedfa8b687d5ac48c48ServiceServiceType
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
    public static class AutoSDKSharedfa8b687d5ac48c48ServiceServiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedfa8b687d5ac48c48ServiceServiceType value)
        {
            return value switch
            {
                AutoSDKSharedfa8b687d5ac48c48ServiceServiceType.Cron => "cron",
                AutoSDKSharedfa8b687d5ac48c48ServiceServiceType.Job => "job",
                AutoSDKSharedfa8b687d5ac48c48ServiceServiceType.Web => "web",
                AutoSDKSharedfa8b687d5ac48c48ServiceServiceType.Worker => "worker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedfa8b687d5ac48c48ServiceServiceType? ToEnum(string value)
        {
            return value switch
            {
                "cron" => AutoSDKSharedfa8b687d5ac48c48ServiceServiceType.Cron,
                "job" => AutoSDKSharedfa8b687d5ac48c48ServiceServiceType.Job,
                "web" => AutoSDKSharedfa8b687d5ac48c48ServiceServiceType.Web,
                "worker" => AutoSDKSharedfa8b687d5ac48c48ServiceServiceType.Worker,
                _ => null,
            };
        }
    }
}