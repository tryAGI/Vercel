
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Service kind (Service.type). Omitted for schemas that do not define one.
    /// </summary>
    public enum AutoSDKSharedfe1f84289679c6c4ServiceServiceType
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
    public static class AutoSDKSharedfe1f84289679c6c4ServiceServiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedfe1f84289679c6c4ServiceServiceType value)
        {
            return value switch
            {
                AutoSDKSharedfe1f84289679c6c4ServiceServiceType.Cron => "cron",
                AutoSDKSharedfe1f84289679c6c4ServiceServiceType.Job => "job",
                AutoSDKSharedfe1f84289679c6c4ServiceServiceType.Web => "web",
                AutoSDKSharedfe1f84289679c6c4ServiceServiceType.Worker => "worker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedfe1f84289679c6c4ServiceServiceType? ToEnum(string value)
        {
            return value switch
            {
                "cron" => AutoSDKSharedfe1f84289679c6c4ServiceServiceType.Cron,
                "job" => AutoSDKSharedfe1f84289679c6c4ServiceServiceType.Job,
                "web" => AutoSDKSharedfe1f84289679c6c4ServiceServiceType.Web,
                "worker" => AutoSDKSharedfe1f84289679c6c4ServiceServiceType.Worker,
                _ => null,
            };
        }
    }
}