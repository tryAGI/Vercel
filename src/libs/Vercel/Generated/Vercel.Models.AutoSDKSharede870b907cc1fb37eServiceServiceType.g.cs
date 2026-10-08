
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Service kind (Service.type). Omitted for schemas that do not define one.
    /// </summary>
    public enum AutoSDKSharede870b907cc1fb37eServiceServiceType
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
    public static class AutoSDKSharede870b907cc1fb37eServiceServiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede870b907cc1fb37eServiceServiceType value)
        {
            return value switch
            {
                AutoSDKSharede870b907cc1fb37eServiceServiceType.Cron => "cron",
                AutoSDKSharede870b907cc1fb37eServiceServiceType.Job => "job",
                AutoSDKSharede870b907cc1fb37eServiceServiceType.Web => "web",
                AutoSDKSharede870b907cc1fb37eServiceServiceType.Worker => "worker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede870b907cc1fb37eServiceServiceType? ToEnum(string value)
        {
            return value switch
            {
                "cron" => AutoSDKSharede870b907cc1fb37eServiceServiceType.Cron,
                "job" => AutoSDKSharede870b907cc1fb37eServiceServiceType.Job,
                "web" => AutoSDKSharede870b907cc1fb37eServiceServiceType.Web,
                "worker" => AutoSDKSharede870b907cc1fb37eServiceServiceType.Worker,
                _ => null,
            };
        }
    }
}