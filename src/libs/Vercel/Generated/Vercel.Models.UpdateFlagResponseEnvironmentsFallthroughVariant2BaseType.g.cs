
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFlagResponseEnvironmentsFallthroughVariant2BaseType
    {
        /// <summary>
        /// 
        /// </summary>
        Entity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateFlagResponseEnvironmentsFallthroughVariant2BaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFlagResponseEnvironmentsFallthroughVariant2BaseType value)
        {
            return value switch
            {
                UpdateFlagResponseEnvironmentsFallthroughVariant2BaseType.Entity => "entity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFlagResponseEnvironmentsFallthroughVariant2BaseType? ToEnum(string value)
        {
            return value switch
            {
                "entity" => UpdateFlagResponseEnvironmentsFallthroughVariant2BaseType.Entity,
                _ => null,
            };
        }
    }
}