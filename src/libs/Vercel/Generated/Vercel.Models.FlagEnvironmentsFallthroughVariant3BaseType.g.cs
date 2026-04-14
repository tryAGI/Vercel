
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum FlagEnvironmentsFallthroughVariant3BaseType
    {
        /// <summary>
        /// 
        /// </summary>
        Entity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FlagEnvironmentsFallthroughVariant3BaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FlagEnvironmentsFallthroughVariant3BaseType value)
        {
            return value switch
            {
                FlagEnvironmentsFallthroughVariant3BaseType.Entity => "entity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FlagEnvironmentsFallthroughVariant3BaseType? ToEnum(string value)
        {
            return value switch
            {
                "entity" => FlagEnvironmentsFallthroughVariant3BaseType.Entity,
                _ => null,
            };
        }
    }
}