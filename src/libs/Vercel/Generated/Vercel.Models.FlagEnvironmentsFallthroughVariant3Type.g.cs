
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum FlagEnvironmentsFallthroughVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        Rollout,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FlagEnvironmentsFallthroughVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FlagEnvironmentsFallthroughVariant3Type value)
        {
            return value switch
            {
                FlagEnvironmentsFallthroughVariant3Type.Rollout => "rollout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FlagEnvironmentsFallthroughVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "rollout" => FlagEnvironmentsFallthroughVariant3Type.Rollout,
                _ => null,
            };
        }
    }
}