
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDrainResponseVariant2ProjectAccessVariant1ManagedBy
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
    public static class CreateDrainResponseVariant2ProjectAccessVariant1ManagedByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDrainResponseVariant2ProjectAccessVariant1ManagedBy value)
        {
            return value switch
            {
                CreateDrainResponseVariant2ProjectAccessVariant1ManagedBy.Drain => "drain",
                CreateDrainResponseVariant2ProjectAccessVariant1ManagedBy.Integration => "integration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDrainResponseVariant2ProjectAccessVariant1ManagedBy? ToEnum(string value)
        {
            return value switch
            {
                "drain" => CreateDrainResponseVariant2ProjectAccessVariant1ManagedBy.Drain,
                "integration" => CreateDrainResponseVariant2ProjectAccessVariant1ManagedBy.Integration,
                _ => null,
            };
        }
    }
}