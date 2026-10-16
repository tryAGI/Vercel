
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Service kind (Service.type). Omitted for schemas that do not define one.
    /// </summary>
    public enum AutoSDKShared866bd5cb8fda1c51ServiceServiceType
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
    public static class AutoSDKShared866bd5cb8fda1c51ServiceServiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared866bd5cb8fda1c51ServiceServiceType value)
        {
            return value switch
            {
                AutoSDKShared866bd5cb8fda1c51ServiceServiceType.Cron => "cron",
                AutoSDKShared866bd5cb8fda1c51ServiceServiceType.Job => "job",
                AutoSDKShared866bd5cb8fda1c51ServiceServiceType.Web => "web",
                AutoSDKShared866bd5cb8fda1c51ServiceServiceType.Worker => "worker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared866bd5cb8fda1c51ServiceServiceType? ToEnum(string value)
        {
            return value switch
            {
                "cron" => AutoSDKShared866bd5cb8fda1c51ServiceServiceType.Cron,
                "job" => AutoSDKShared866bd5cb8fda1c51ServiceServiceType.Job,
                "web" => AutoSDKShared866bd5cb8fda1c51ServiceServiceType.Web,
                "worker" => AutoSDKShared866bd5cb8fda1c51ServiceServiceType.Worker,
                _ => null,
            };
        }
    }
}