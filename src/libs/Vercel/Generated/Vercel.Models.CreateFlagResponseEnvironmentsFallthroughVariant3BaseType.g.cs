
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateFlagResponseEnvironmentsFallthroughVariant3BaseType
    {
        /// <summary>
        /// 
        /// </summary>
        Entity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateFlagResponseEnvironmentsFallthroughVariant3BaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateFlagResponseEnvironmentsFallthroughVariant3BaseType value)
        {
            return value switch
            {
                CreateFlagResponseEnvironmentsFallthroughVariant3BaseType.Entity => "entity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateFlagResponseEnvironmentsFallthroughVariant3BaseType? ToEnum(string value)
        {
            return value switch
            {
                "entity" => CreateFlagResponseEnvironmentsFallthroughVariant3BaseType.Entity,
                _ => null,
            };
        }
    }
}