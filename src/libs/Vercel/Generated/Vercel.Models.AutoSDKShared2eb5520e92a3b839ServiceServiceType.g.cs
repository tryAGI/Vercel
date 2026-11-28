
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Service kind (Service.type). Omitted for schemas that do not define one.
    /// </summary>
    public enum AutoSDKShared2eb5520e92a3b839ServiceServiceType
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
    public static class AutoSDKShared2eb5520e92a3b839ServiceServiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared2eb5520e92a3b839ServiceServiceType value)
        {
            return value switch
            {
                AutoSDKShared2eb5520e92a3b839ServiceServiceType.Cron => "cron",
                AutoSDKShared2eb5520e92a3b839ServiceServiceType.Job => "job",
                AutoSDKShared2eb5520e92a3b839ServiceServiceType.Web => "web",
                AutoSDKShared2eb5520e92a3b839ServiceServiceType.Worker => "worker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared2eb5520e92a3b839ServiceServiceType? ToEnum(string value)
        {
            return value switch
            {
                "cron" => AutoSDKShared2eb5520e92a3b839ServiceServiceType.Cron,
                "job" => AutoSDKShared2eb5520e92a3b839ServiceServiceType.Job,
                "web" => AutoSDKShared2eb5520e92a3b839ServiceServiceType.Web,
                "worker" => AutoSDKShared2eb5520e92a3b839ServiceServiceType.Worker,
                _ => null,
            };
        }
    }
}