
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateFlagResponseEnvironmentsFallthroughVariant2BaseType
    {
        /// <summary>
        /// 
        /// </summary>
        Entity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateFlagResponseEnvironmentsFallthroughVariant2BaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateFlagResponseEnvironmentsFallthroughVariant2BaseType value)
        {
            return value switch
            {
                CreateFlagResponseEnvironmentsFallthroughVariant2BaseType.Entity => "entity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateFlagResponseEnvironmentsFallthroughVariant2BaseType? ToEnum(string value)
        {
            return value switch
            {
                "entity" => CreateFlagResponseEnvironmentsFallthroughVariant2BaseType.Entity,
                _ => null,
            };
        }
    }
}