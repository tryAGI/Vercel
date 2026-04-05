
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum FlagEnvironmentsFallthroughVariant2BaseType
    {
        /// <summary>
        /// 
        /// </summary>
        Entity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FlagEnvironmentsFallthroughVariant2BaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FlagEnvironmentsFallthroughVariant2BaseType value)
        {
            return value switch
            {
                FlagEnvironmentsFallthroughVariant2BaseType.Entity => "entity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FlagEnvironmentsFallthroughVariant2BaseType? ToEnum(string value)
        {
            return value switch
            {
                "entity" => FlagEnvironmentsFallthroughVariant2BaseType.Entity,
                _ => null,
            };
        }
    }
}