
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Service kind (Service.type). Omitted for schemas that do not define one.
    /// </summary>
    public enum AutoSDKShared9bbe6cc4d61f3bf2ServiceServiceType
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
    public static class AutoSDKShared9bbe6cc4d61f3bf2ServiceServiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared9bbe6cc4d61f3bf2ServiceServiceType value)
        {
            return value switch
            {
                AutoSDKShared9bbe6cc4d61f3bf2ServiceServiceType.Cron => "cron",
                AutoSDKShared9bbe6cc4d61f3bf2ServiceServiceType.Job => "job",
                AutoSDKShared9bbe6cc4d61f3bf2ServiceServiceType.Web => "web",
                AutoSDKShared9bbe6cc4d61f3bf2ServiceServiceType.Worker => "worker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared9bbe6cc4d61f3bf2ServiceServiceType? ToEnum(string value)
        {
            return value switch
            {
                "cron" => AutoSDKShared9bbe6cc4d61f3bf2ServiceServiceType.Cron,
                "job" => AutoSDKShared9bbe6cc4d61f3bf2ServiceServiceType.Job,
                "web" => AutoSDKShared9bbe6cc4d61f3bf2ServiceServiceType.Web,
                "worker" => AutoSDKShared9bbe6cc4d61f3bf2ServiceServiceType.Worker,
                _ => null,
            };
        }
    }
}