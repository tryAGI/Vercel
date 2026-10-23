
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Service kind (Service.type). Omitted for schemas that do not define one.
    /// </summary>
    public enum AutoSDKShared52fb994527107e75ServiceServiceType
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
    public static class AutoSDKShared52fb994527107e75ServiceServiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared52fb994527107e75ServiceServiceType value)
        {
            return value switch
            {
                AutoSDKShared52fb994527107e75ServiceServiceType.Cron => "cron",
                AutoSDKShared52fb994527107e75ServiceServiceType.Job => "job",
                AutoSDKShared52fb994527107e75ServiceServiceType.Web => "web",
                AutoSDKShared52fb994527107e75ServiceServiceType.Worker => "worker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared52fb994527107e75ServiceServiceType? ToEnum(string value)
        {
            return value switch
            {
                "cron" => AutoSDKShared52fb994527107e75ServiceServiceType.Cron,
                "job" => AutoSDKShared52fb994527107e75ServiceServiceType.Job,
                "web" => AutoSDKShared52fb994527107e75ServiceServiceType.Web,
                "worker" => AutoSDKShared52fb994527107e75ServiceServiceType.Worker,
                _ => null,
            };
        }
    }
}