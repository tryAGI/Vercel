
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateFlagResponseEnvironmentsFallthroughVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        Rollout,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateFlagResponseEnvironmentsFallthroughVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateFlagResponseEnvironmentsFallthroughVariant3Type value)
        {
            return value switch
            {
                CreateFlagResponseEnvironmentsFallthroughVariant3Type.Rollout => "rollout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateFlagResponseEnvironmentsFallthroughVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "rollout" => CreateFlagResponseEnvironmentsFallthroughVariant3Type.Rollout,
                _ => null,
            };
        }
    }
}