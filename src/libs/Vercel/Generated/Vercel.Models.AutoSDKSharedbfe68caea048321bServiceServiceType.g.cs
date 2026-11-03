
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Service kind (Service.type). Omitted for schemas that do not define one.
    /// </summary>
    public enum AutoSDKSharedbfe68caea048321bServiceServiceType
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
    public static class AutoSDKSharedbfe68caea048321bServiceServiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedbfe68caea048321bServiceServiceType value)
        {
            return value switch
            {
                AutoSDKSharedbfe68caea048321bServiceServiceType.Cron => "cron",
                AutoSDKSharedbfe68caea048321bServiceServiceType.Job => "job",
                AutoSDKSharedbfe68caea048321bServiceServiceType.Web => "web",
                AutoSDKSharedbfe68caea048321bServiceServiceType.Worker => "worker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedbfe68caea048321bServiceServiceType? ToEnum(string value)
        {
            return value switch
            {
                "cron" => AutoSDKSharedbfe68caea048321bServiceServiceType.Cron,
                "job" => AutoSDKSharedbfe68caea048321bServiceServiceType.Job,
                "web" => AutoSDKSharedbfe68caea048321bServiceServiceType.Web,
                "worker" => AutoSDKSharedbfe68caea048321bServiceServiceType.Worker,
                _ => null,
            };
        }
    }
}