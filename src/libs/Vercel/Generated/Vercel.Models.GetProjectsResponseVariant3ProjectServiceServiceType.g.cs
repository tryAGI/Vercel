
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Service kind (Service.type). Omitted for schemas that do not define one.
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectServiceServiceType
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
    public static class GetProjectsResponseVariant3ProjectServiceServiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectServiceServiceType value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectServiceServiceType.Cron => "cron",
                GetProjectsResponseVariant3ProjectServiceServiceType.Job => "job",
                GetProjectsResponseVariant3ProjectServiceServiceType.Web => "web",
                GetProjectsResponseVariant3ProjectServiceServiceType.Worker => "worker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectServiceServiceType? ToEnum(string value)
        {
            return value switch
            {
                "cron" => GetProjectsResponseVariant3ProjectServiceServiceType.Cron,
                "job" => GetProjectsResponseVariant3ProjectServiceServiceType.Job,
                "web" => GetProjectsResponseVariant3ProjectServiceServiceType.Web,
                "worker" => GetProjectsResponseVariant3ProjectServiceServiceType.Worker,
                _ => null,
            };
        }
    }
}