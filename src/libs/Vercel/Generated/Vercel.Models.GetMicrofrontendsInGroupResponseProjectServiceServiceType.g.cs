
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Service kind (Service.type). Omitted for schemas that do not define one.
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectServiceServiceType
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
    public static class GetMicrofrontendsInGroupResponseProjectServiceServiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectServiceServiceType value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectServiceServiceType.Cron => "cron",
                GetMicrofrontendsInGroupResponseProjectServiceServiceType.Job => "job",
                GetMicrofrontendsInGroupResponseProjectServiceServiceType.Web => "web",
                GetMicrofrontendsInGroupResponseProjectServiceServiceType.Worker => "worker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectServiceServiceType? ToEnum(string value)
        {
            return value switch
            {
                "cron" => GetMicrofrontendsInGroupResponseProjectServiceServiceType.Cron,
                "job" => GetMicrofrontendsInGroupResponseProjectServiceServiceType.Job,
                "web" => GetMicrofrontendsInGroupResponseProjectServiceServiceType.Web,
                "worker" => GetMicrofrontendsInGroupResponseProjectServiceServiceType.Worker,
                _ => null,
            };
        }
    }
}