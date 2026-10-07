
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Service kind (Service.type). Omitted for schemas that do not define one.
    /// </summary>
    public enum AutoSDKShared223443184387411fServiceServiceType
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
    public static class AutoSDKShared223443184387411fServiceServiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared223443184387411fServiceServiceType value)
        {
            return value switch
            {
                AutoSDKShared223443184387411fServiceServiceType.Cron => "cron",
                AutoSDKShared223443184387411fServiceServiceType.Job => "job",
                AutoSDKShared223443184387411fServiceServiceType.Web => "web",
                AutoSDKShared223443184387411fServiceServiceType.Worker => "worker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared223443184387411fServiceServiceType? ToEnum(string value)
        {
            return value switch
            {
                "cron" => AutoSDKShared223443184387411fServiceServiceType.Cron,
                "job" => AutoSDKShared223443184387411fServiceServiceType.Job,
                "web" => AutoSDKShared223443184387411fServiceServiceType.Web,
                "worker" => AutoSDKShared223443184387411fServiceServiceType.Worker,
                _ => null,
            };
        }
    }
}