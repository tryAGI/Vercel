
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Service kind (Service.type). Omitted for schemas that do not define one.
    /// </summary>
    public enum AutoSDKSharede0e23f3391031fa6ServiceServiceType
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
    public static class AutoSDKSharede0e23f3391031fa6ServiceServiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede0e23f3391031fa6ServiceServiceType value)
        {
            return value switch
            {
                AutoSDKSharede0e23f3391031fa6ServiceServiceType.Cron => "cron",
                AutoSDKSharede0e23f3391031fa6ServiceServiceType.Job => "job",
                AutoSDKSharede0e23f3391031fa6ServiceServiceType.Web => "web",
                AutoSDKSharede0e23f3391031fa6ServiceServiceType.Worker => "worker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede0e23f3391031fa6ServiceServiceType? ToEnum(string value)
        {
            return value switch
            {
                "cron" => AutoSDKSharede0e23f3391031fa6ServiceServiceType.Cron,
                "job" => AutoSDKSharede0e23f3391031fa6ServiceServiceType.Job,
                "web" => AutoSDKSharede0e23f3391031fa6ServiceServiceType.Web,
                "worker" => AutoSDKSharede0e23f3391031fa6ServiceServiceType.Worker,
                _ => null,
            };
        }
    }
}