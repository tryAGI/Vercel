
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Service kind (Service.type). Omitted for schemas that do not define one.
    /// </summary>
    public enum AutoSDKSharedd9ba619caaa0a759ServiceServiceType
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
    public static class AutoSDKSharedd9ba619caaa0a759ServiceServiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedd9ba619caaa0a759ServiceServiceType value)
        {
            return value switch
            {
                AutoSDKSharedd9ba619caaa0a759ServiceServiceType.Cron => "cron",
                AutoSDKSharedd9ba619caaa0a759ServiceServiceType.Job => "job",
                AutoSDKSharedd9ba619caaa0a759ServiceServiceType.Web => "web",
                AutoSDKSharedd9ba619caaa0a759ServiceServiceType.Worker => "worker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedd9ba619caaa0a759ServiceServiceType? ToEnum(string value)
        {
            return value switch
            {
                "cron" => AutoSDKSharedd9ba619caaa0a759ServiceServiceType.Cron,
                "job" => AutoSDKSharedd9ba619caaa0a759ServiceServiceType.Job,
                "web" => AutoSDKSharedd9ba619caaa0a759ServiceServiceType.Web,
                "worker" => AutoSDKSharedd9ba619caaa0a759ServiceServiceType.Worker,
                _ => null,
            };
        }
    }
}