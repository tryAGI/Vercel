
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Service kind (Service.type). Omitted for schemas that do not define one.
    /// </summary>
    public enum AutoSDKShareda223f19b9c37327fServiceServiceType
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
    public static class AutoSDKShareda223f19b9c37327fServiceServiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda223f19b9c37327fServiceServiceType value)
        {
            return value switch
            {
                AutoSDKShareda223f19b9c37327fServiceServiceType.Cron => "cron",
                AutoSDKShareda223f19b9c37327fServiceServiceType.Job => "job",
                AutoSDKShareda223f19b9c37327fServiceServiceType.Web => "web",
                AutoSDKShareda223f19b9c37327fServiceServiceType.Worker => "worker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda223f19b9c37327fServiceServiceType? ToEnum(string value)
        {
            return value switch
            {
                "cron" => AutoSDKShareda223f19b9c37327fServiceServiceType.Cron,
                "job" => AutoSDKShareda223f19b9c37327fServiceServiceType.Job,
                "web" => AutoSDKShareda223f19b9c37327fServiceServiceType.Web,
                "worker" => AutoSDKShareda223f19b9c37327fServiceServiceType.Worker,
                _ => null,
            };
        }
    }
}