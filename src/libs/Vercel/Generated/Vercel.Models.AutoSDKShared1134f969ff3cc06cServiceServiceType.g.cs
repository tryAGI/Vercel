
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Service kind (Service.type). Omitted for schemas that do not define one.
    /// </summary>
    public enum AutoSDKShared1134f969ff3cc06cServiceServiceType
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
    public static class AutoSDKShared1134f969ff3cc06cServiceServiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared1134f969ff3cc06cServiceServiceType value)
        {
            return value switch
            {
                AutoSDKShared1134f969ff3cc06cServiceServiceType.Cron => "cron",
                AutoSDKShared1134f969ff3cc06cServiceServiceType.Job => "job",
                AutoSDKShared1134f969ff3cc06cServiceServiceType.Web => "web",
                AutoSDKShared1134f969ff3cc06cServiceServiceType.Worker => "worker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared1134f969ff3cc06cServiceServiceType? ToEnum(string value)
        {
            return value switch
            {
                "cron" => AutoSDKShared1134f969ff3cc06cServiceServiceType.Cron,
                "job" => AutoSDKShared1134f969ff3cc06cServiceServiceType.Job,
                "web" => AutoSDKShared1134f969ff3cc06cServiceServiceType.Web,
                "worker" => AutoSDKShared1134f969ff3cc06cServiceServiceType.Worker,
                _ => null,
            };
        }
    }
}