
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Service kind (Service.type). Omitted for schemas that do not define one.
    /// </summary>
    public enum CreateProjectResponseServiceServiceType
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
    public static class CreateProjectResponseServiceServiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseServiceServiceType value)
        {
            return value switch
            {
                CreateProjectResponseServiceServiceType.Cron => "cron",
                CreateProjectResponseServiceServiceType.Job => "job",
                CreateProjectResponseServiceServiceType.Web => "web",
                CreateProjectResponseServiceServiceType.Worker => "worker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseServiceServiceType? ToEnum(string value)
        {
            return value switch
            {
                "cron" => CreateProjectResponseServiceServiceType.Cron,
                "job" => CreateProjectResponseServiceServiceType.Job,
                "web" => CreateProjectResponseServiceServiceType.Web,
                "worker" => CreateProjectResponseServiceServiceType.Worker,
                _ => null,
            };
        }
    }
}