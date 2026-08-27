
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Service kind (Service.type). Omitted for schemas that do not define one.
    /// </summary>
    public enum GetProjectResponseServiceServiceType
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
    public static class GetProjectResponseServiceServiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseServiceServiceType value)
        {
            return value switch
            {
                GetProjectResponseServiceServiceType.Cron => "cron",
                GetProjectResponseServiceServiceType.Job => "job",
                GetProjectResponseServiceServiceType.Web => "web",
                GetProjectResponseServiceServiceType.Worker => "worker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseServiceServiceType? ToEnum(string value)
        {
            return value switch
            {
                "cron" => GetProjectResponseServiceServiceType.Cron,
                "job" => GetProjectResponseServiceServiceType.Job,
                "web" => GetProjectResponseServiceServiceType.Web,
                "worker" => GetProjectResponseServiceServiceType.Worker,
                _ => null,
            };
        }
    }
}