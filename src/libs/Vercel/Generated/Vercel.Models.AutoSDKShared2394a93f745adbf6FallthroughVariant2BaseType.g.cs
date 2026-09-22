
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared2394a93f745adbf6FallthroughVariant2BaseType
    {
        /// <summary>
        ///
        /// </summary>
        Entity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared2394a93f745adbf6FallthroughVariant2BaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared2394a93f745adbf6FallthroughVariant2BaseType value)
        {
            return value switch
            {
                AutoSDKShared2394a93f745adbf6FallthroughVariant2BaseType.Entity => "entity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared2394a93f745adbf6FallthroughVariant2BaseType? ToEnum(string value)
        {
            return value switch
            {
                "entity" => AutoSDKShared2394a93f745adbf6FallthroughVariant2BaseType.Entity,
                _ => null,
            };
        }
    }
}