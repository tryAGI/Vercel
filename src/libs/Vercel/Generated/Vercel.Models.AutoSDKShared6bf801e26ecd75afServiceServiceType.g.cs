
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Service kind (Service.type). Omitted for schemas that do not define one.
    /// </summary>
    public enum AutoSDKShared6bf801e26ecd75afServiceServiceType
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
    public static class AutoSDKShared6bf801e26ecd75afServiceServiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6bf801e26ecd75afServiceServiceType value)
        {
            return value switch
            {
                AutoSDKShared6bf801e26ecd75afServiceServiceType.Cron => "cron",
                AutoSDKShared6bf801e26ecd75afServiceServiceType.Job => "job",
                AutoSDKShared6bf801e26ecd75afServiceServiceType.Web => "web",
                AutoSDKShared6bf801e26ecd75afServiceServiceType.Worker => "worker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6bf801e26ecd75afServiceServiceType? ToEnum(string value)
        {
            return value switch
            {
                "cron" => AutoSDKShared6bf801e26ecd75afServiceServiceType.Cron,
                "job" => AutoSDKShared6bf801e26ecd75afServiceServiceType.Job,
                "web" => AutoSDKShared6bf801e26ecd75afServiceServiceType.Web,
                "worker" => AutoSDKShared6bf801e26ecd75afServiceServiceType.Worker,
                _ => null,
            };
        }
    }
}