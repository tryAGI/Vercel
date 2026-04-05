
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDrainResponseVariant2ProjectAccessVariant2ManagedBy
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
    public static class CreateDrainResponseVariant2ProjectAccessVariant2ManagedByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDrainResponseVariant2ProjectAccessVariant2ManagedBy value)
        {
            return value switch
            {
                CreateDrainResponseVariant2ProjectAccessVariant2ManagedBy.Drain => "drain",
                CreateDrainResponseVariant2ProjectAccessVariant2ManagedBy.Integration => "integration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDrainResponseVariant2ProjectAccessVariant2ManagedBy? ToEnum(string value)
        {
            return value switch
            {
                "drain" => CreateDrainResponseVariant2ProjectAccessVariant2ManagedBy.Drain,
                "integration" => CreateDrainResponseVariant2ProjectAccessVariant2ManagedBy.Integration,
                _ => null,
            };
        }
    }
}