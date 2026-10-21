
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Service kind (Service.type). Omitted for schemas that do not define one.
    /// </summary>
    public enum AutoSDKShared0d52d5fc16437df8ServiceServiceType
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
    public static class AutoSDKShared0d52d5fc16437df8ServiceServiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0d52d5fc16437df8ServiceServiceType value)
        {
            return value switch
            {
                AutoSDKShared0d52d5fc16437df8ServiceServiceType.Cron => "cron",
                AutoSDKShared0d52d5fc16437df8ServiceServiceType.Job => "job",
                AutoSDKShared0d52d5fc16437df8ServiceServiceType.Web => "web",
                AutoSDKShared0d52d5fc16437df8ServiceServiceType.Worker => "worker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0d52d5fc16437df8ServiceServiceType? ToEnum(string value)
        {
            return value switch
            {
                "cron" => AutoSDKShared0d52d5fc16437df8ServiceServiceType.Cron,
                "job" => AutoSDKShared0d52d5fc16437df8ServiceServiceType.Job,
                "web" => AutoSDKShared0d52d5fc16437df8ServiceServiceType.Web,
                "worker" => AutoSDKShared0d52d5fc16437df8ServiceServiceType.Worker,
                _ => null,
            };
        }
    }
}