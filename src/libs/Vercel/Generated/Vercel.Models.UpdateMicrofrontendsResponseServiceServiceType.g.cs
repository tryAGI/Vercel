
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Service kind (Service.type). Omitted for schemas that do not define one.
    /// </summary>
    public enum UpdateMicrofrontendsResponseServiceServiceType
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
    public static class UpdateMicrofrontendsResponseServiceServiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseServiceServiceType value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseServiceServiceType.Cron => "cron",
                UpdateMicrofrontendsResponseServiceServiceType.Job => "job",
                UpdateMicrofrontendsResponseServiceServiceType.Web => "web",
                UpdateMicrofrontendsResponseServiceServiceType.Worker => "worker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseServiceServiceType? ToEnum(string value)
        {
            return value switch
            {
                "cron" => UpdateMicrofrontendsResponseServiceServiceType.Cron,
                "job" => UpdateMicrofrontendsResponseServiceServiceType.Job,
                "web" => UpdateMicrofrontendsResponseServiceServiceType.Web,
                "worker" => UpdateMicrofrontendsResponseServiceServiceType.Worker,
                _ => null,
            };
        }
    }
}