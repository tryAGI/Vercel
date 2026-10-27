
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Service kind (Service.type). Omitted for schemas that do not define one.
    /// </summary>
    public enum AutoSDKShared429ed81b15078f20ServiceServiceType
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
    public static class AutoSDKShared429ed81b15078f20ServiceServiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared429ed81b15078f20ServiceServiceType value)
        {
            return value switch
            {
                AutoSDKShared429ed81b15078f20ServiceServiceType.Cron => "cron",
                AutoSDKShared429ed81b15078f20ServiceServiceType.Job => "job",
                AutoSDKShared429ed81b15078f20ServiceServiceType.Web => "web",
                AutoSDKShared429ed81b15078f20ServiceServiceType.Worker => "worker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared429ed81b15078f20ServiceServiceType? ToEnum(string value)
        {
            return value switch
            {
                "cron" => AutoSDKShared429ed81b15078f20ServiceServiceType.Cron,
                "job" => AutoSDKShared429ed81b15078f20ServiceServiceType.Job,
                "web" => AutoSDKShared429ed81b15078f20ServiceServiceType.Web,
                "worker" => AutoSDKShared429ed81b15078f20ServiceServiceType.Worker,
                _ => null,
            };
        }
    }
}