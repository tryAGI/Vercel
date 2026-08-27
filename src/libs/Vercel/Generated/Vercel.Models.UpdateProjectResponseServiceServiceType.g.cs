
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Service kind (Service.type). Omitted for schemas that do not define one.
    /// </summary>
    public enum UpdateProjectResponseServiceServiceType
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
    public static class UpdateProjectResponseServiceServiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseServiceServiceType value)
        {
            return value switch
            {
                UpdateProjectResponseServiceServiceType.Cron => "cron",
                UpdateProjectResponseServiceServiceType.Job => "job",
                UpdateProjectResponseServiceServiceType.Web => "web",
                UpdateProjectResponseServiceServiceType.Worker => "worker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseServiceServiceType? ToEnum(string value)
        {
            return value switch
            {
                "cron" => UpdateProjectResponseServiceServiceType.Cron,
                "job" => UpdateProjectResponseServiceServiceType.Job,
                "web" => UpdateProjectResponseServiceServiceType.Web,
                "worker" => UpdateProjectResponseServiceServiceType.Worker,
                _ => null,
            };
        }
    }
}