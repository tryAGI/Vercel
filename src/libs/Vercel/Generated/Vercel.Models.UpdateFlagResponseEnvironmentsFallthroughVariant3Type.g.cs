
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFlagResponseEnvironmentsFallthroughVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        Rollout,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateFlagResponseEnvironmentsFallthroughVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFlagResponseEnvironmentsFallthroughVariant3Type value)
        {
            return value switch
            {
                UpdateFlagResponseEnvironmentsFallthroughVariant3Type.Rollout => "rollout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFlagResponseEnvironmentsFallthroughVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "rollout" => UpdateFlagResponseEnvironmentsFallthroughVariant3Type.Rollout,
                _ => null,
            };
        }
    }
}