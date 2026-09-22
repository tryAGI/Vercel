
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared2394a93f745adbf6FallthroughVariant3Type
    {
        /// <summary>
        ///
        /// </summary>
        Rollout,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared2394a93f745adbf6FallthroughVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared2394a93f745adbf6FallthroughVariant3Type value)
        {
            return value switch
            {
                AutoSDKShared2394a93f745adbf6FallthroughVariant3Type.Rollout => "rollout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared2394a93f745adbf6FallthroughVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "rollout" => AutoSDKShared2394a93f745adbf6FallthroughVariant3Type.Rollout,
                _ => null,
            };
        }
    }
}