
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared1e1af2b60dfcf13aFallthroughVariant3Type
    {
        /// <summary>
        ///
        /// </summary>
        Rollout,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared1e1af2b60dfcf13aFallthroughVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared1e1af2b60dfcf13aFallthroughVariant3Type value)
        {
            return value switch
            {
                AutoSDKShared1e1af2b60dfcf13aFallthroughVariant3Type.Rollout => "rollout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared1e1af2b60dfcf13aFallthroughVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "rollout" => AutoSDKShared1e1af2b60dfcf13aFallthroughVariant3Type.Rollout,
                _ => null,
            };
        }
    }
}