
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Service kind (Service.type). Omitted for schemas that do not define one.
    /// </summary>
    public enum AutoSDKShareda2d284b091a73479ServiceServiceType
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
    public static class AutoSDKShareda2d284b091a73479ServiceServiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda2d284b091a73479ServiceServiceType value)
        {
            return value switch
            {
                AutoSDKShareda2d284b091a73479ServiceServiceType.Cron => "cron",
                AutoSDKShareda2d284b091a73479ServiceServiceType.Job => "job",
                AutoSDKShareda2d284b091a73479ServiceServiceType.Web => "web",
                AutoSDKShareda2d284b091a73479ServiceServiceType.Worker => "worker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda2d284b091a73479ServiceServiceType? ToEnum(string value)
        {
            return value switch
            {
                "cron" => AutoSDKShareda2d284b091a73479ServiceServiceType.Cron,
                "job" => AutoSDKShareda2d284b091a73479ServiceServiceType.Job,
                "web" => AutoSDKShareda2d284b091a73479ServiceServiceType.Web,
                "worker" => AutoSDKShareda2d284b091a73479ServiceServiceType.Worker,
                _ => null,
            };
        }
    }
}