
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Service kind (Service.type). Omitted for schemas that do not define one.
    /// </summary>
    public enum AutoSDKSharedbe3f0c688bc34a31ServiceServiceType
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
    public static class AutoSDKSharedbe3f0c688bc34a31ServiceServiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedbe3f0c688bc34a31ServiceServiceType value)
        {
            return value switch
            {
                AutoSDKSharedbe3f0c688bc34a31ServiceServiceType.Cron => "cron",
                AutoSDKSharedbe3f0c688bc34a31ServiceServiceType.Job => "job",
                AutoSDKSharedbe3f0c688bc34a31ServiceServiceType.Web => "web",
                AutoSDKSharedbe3f0c688bc34a31ServiceServiceType.Worker => "worker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedbe3f0c688bc34a31ServiceServiceType? ToEnum(string value)
        {
            return value switch
            {
                "cron" => AutoSDKSharedbe3f0c688bc34a31ServiceServiceType.Cron,
                "job" => AutoSDKSharedbe3f0c688bc34a31ServiceServiceType.Job,
                "web" => AutoSDKSharedbe3f0c688bc34a31ServiceServiceType.Web,
                "worker" => AutoSDKSharedbe3f0c688bc34a31ServiceServiceType.Worker,
                _ => null,
            };
        }
    }
}