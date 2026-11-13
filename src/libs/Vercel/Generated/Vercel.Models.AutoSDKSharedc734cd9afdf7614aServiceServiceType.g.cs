
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Service kind (Service.type). Omitted for schemas that do not define one.
    /// </summary>
    public enum AutoSDKSharedc734cd9afdf7614aServiceServiceType
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
    public static class AutoSDKSharedc734cd9afdf7614aServiceServiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc734cd9afdf7614aServiceServiceType value)
        {
            return value switch
            {
                AutoSDKSharedc734cd9afdf7614aServiceServiceType.Cron => "cron",
                AutoSDKSharedc734cd9afdf7614aServiceServiceType.Job => "job",
                AutoSDKSharedc734cd9afdf7614aServiceServiceType.Web => "web",
                AutoSDKSharedc734cd9afdf7614aServiceServiceType.Worker => "worker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc734cd9afdf7614aServiceServiceType? ToEnum(string value)
        {
            return value switch
            {
                "cron" => AutoSDKSharedc734cd9afdf7614aServiceServiceType.Cron,
                "job" => AutoSDKSharedc734cd9afdf7614aServiceServiceType.Job,
                "web" => AutoSDKSharedc734cd9afdf7614aServiceServiceType.Web,
                "worker" => AutoSDKSharedc734cd9afdf7614aServiceServiceType.Worker,
                _ => null,
            };
        }
    }
}