
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Service kind (Service.type). Omitted for schemas that do not define one.
    /// </summary>
    public enum AutoSDKSharede052f139ff613de3ServiceServiceType
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
    public static class AutoSDKSharede052f139ff613de3ServiceServiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede052f139ff613de3ServiceServiceType value)
        {
            return value switch
            {
                AutoSDKSharede052f139ff613de3ServiceServiceType.Cron => "cron",
                AutoSDKSharede052f139ff613de3ServiceServiceType.Job => "job",
                AutoSDKSharede052f139ff613de3ServiceServiceType.Web => "web",
                AutoSDKSharede052f139ff613de3ServiceServiceType.Worker => "worker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede052f139ff613de3ServiceServiceType? ToEnum(string value)
        {
            return value switch
            {
                "cron" => AutoSDKSharede052f139ff613de3ServiceServiceType.Cron,
                "job" => AutoSDKSharede052f139ff613de3ServiceServiceType.Job,
                "web" => AutoSDKSharede052f139ff613de3ServiceServiceType.Web,
                "worker" => AutoSDKSharede052f139ff613de3ServiceServiceType.Worker,
                _ => null,
            };
        }
    }
}