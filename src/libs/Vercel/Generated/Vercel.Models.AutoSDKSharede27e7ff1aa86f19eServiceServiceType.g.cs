
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Service kind (Service.type). Omitted for schemas that do not define one.
    /// </summary>
    public enum AutoSDKSharede27e7ff1aa86f19eServiceServiceType
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
    public static class AutoSDKSharede27e7ff1aa86f19eServiceServiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede27e7ff1aa86f19eServiceServiceType value)
        {
            return value switch
            {
                AutoSDKSharede27e7ff1aa86f19eServiceServiceType.Cron => "cron",
                AutoSDKSharede27e7ff1aa86f19eServiceServiceType.Job => "job",
                AutoSDKSharede27e7ff1aa86f19eServiceServiceType.Web => "web",
                AutoSDKSharede27e7ff1aa86f19eServiceServiceType.Worker => "worker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede27e7ff1aa86f19eServiceServiceType? ToEnum(string value)
        {
            return value switch
            {
                "cron" => AutoSDKSharede27e7ff1aa86f19eServiceServiceType.Cron,
                "job" => AutoSDKSharede27e7ff1aa86f19eServiceServiceType.Job,
                "web" => AutoSDKSharede27e7ff1aa86f19eServiceServiceType.Web,
                "worker" => AutoSDKSharede27e7ff1aa86f19eServiceServiceType.Worker,
                _ => null,
            };
        }
    }
}