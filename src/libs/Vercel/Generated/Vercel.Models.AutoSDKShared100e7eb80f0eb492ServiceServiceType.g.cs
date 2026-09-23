
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Service kind (Service.type). Omitted for schemas that do not define one.
    /// </summary>
    public enum AutoSDKShared100e7eb80f0eb492ServiceServiceType
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
    public static class AutoSDKShared100e7eb80f0eb492ServiceServiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared100e7eb80f0eb492ServiceServiceType value)
        {
            return value switch
            {
                AutoSDKShared100e7eb80f0eb492ServiceServiceType.Cron => "cron",
                AutoSDKShared100e7eb80f0eb492ServiceServiceType.Job => "job",
                AutoSDKShared100e7eb80f0eb492ServiceServiceType.Web => "web",
                AutoSDKShared100e7eb80f0eb492ServiceServiceType.Worker => "worker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared100e7eb80f0eb492ServiceServiceType? ToEnum(string value)
        {
            return value switch
            {
                "cron" => AutoSDKShared100e7eb80f0eb492ServiceServiceType.Cron,
                "job" => AutoSDKShared100e7eb80f0eb492ServiceServiceType.Job,
                "web" => AutoSDKShared100e7eb80f0eb492ServiceServiceType.Web,
                "worker" => AutoSDKShared100e7eb80f0eb492ServiceServiceType.Worker,
                _ => null,
            };
        }
    }
}