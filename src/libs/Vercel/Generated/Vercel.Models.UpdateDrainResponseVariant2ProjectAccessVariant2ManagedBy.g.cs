
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateDrainResponseVariant2ProjectAccessVariant2ManagedBy
    {
        /// <summary>
        /// 
        /// </summary>
        Drain,
        /// <summary>
        /// 
        /// </summary>
        Integration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateDrainResponseVariant2ProjectAccessVariant2ManagedByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDrainResponseVariant2ProjectAccessVariant2ManagedBy value)
        {
            return value switch
            {
                UpdateDrainResponseVariant2ProjectAccessVariant2ManagedBy.Drain => "drain",
                UpdateDrainResponseVariant2ProjectAccessVariant2ManagedBy.Integration => "integration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDrainResponseVariant2ProjectAccessVariant2ManagedBy? ToEnum(string value)
        {
            return value switch
            {
                "drain" => UpdateDrainResponseVariant2ProjectAccessVariant2ManagedBy.Drain,
                "integration" => UpdateDrainResponseVariant2ProjectAccessVariant2ManagedBy.Integration,
                _ => null,
            };
        }
    }
}