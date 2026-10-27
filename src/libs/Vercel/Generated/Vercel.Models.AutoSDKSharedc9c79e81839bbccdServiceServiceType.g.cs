
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Service kind (Service.type). Omitted for schemas that do not define one.
    /// </summary>
    public enum AutoSDKSharedc9c79e81839bbccdServiceServiceType
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
    public static class AutoSDKSharedc9c79e81839bbccdServiceServiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc9c79e81839bbccdServiceServiceType value)
        {
            return value switch
            {
                AutoSDKSharedc9c79e81839bbccdServiceServiceType.Cron => "cron",
                AutoSDKSharedc9c79e81839bbccdServiceServiceType.Job => "job",
                AutoSDKSharedc9c79e81839bbccdServiceServiceType.Web => "web",
                AutoSDKSharedc9c79e81839bbccdServiceServiceType.Worker => "worker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc9c79e81839bbccdServiceServiceType? ToEnum(string value)
        {
            return value switch
            {
                "cron" => AutoSDKSharedc9c79e81839bbccdServiceServiceType.Cron,
                "job" => AutoSDKSharedc9c79e81839bbccdServiceServiceType.Job,
                "web" => AutoSDKSharedc9c79e81839bbccdServiceServiceType.Web,
                "worker" => AutoSDKSharedc9c79e81839bbccdServiceServiceType.Worker,
                _ => null,
            };
        }
    }
}