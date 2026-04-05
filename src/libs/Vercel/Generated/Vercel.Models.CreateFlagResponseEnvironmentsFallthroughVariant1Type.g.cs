
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateFlagResponseEnvironmentsFallthroughVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Variant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateFlagResponseEnvironmentsFallthroughVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateFlagResponseEnvironmentsFallthroughVariant1Type value)
        {
            return value switch
            {
                CreateFlagResponseEnvironmentsFallthroughVariant1Type.Variant => "variant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateFlagResponseEnvironmentsFallthroughVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "variant" => CreateFlagResponseEnvironmentsFallthroughVariant1Type.Variant,
                _ => null,
            };
        }
    }
}