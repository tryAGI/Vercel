
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared1e1af2b60dfcf13aFallthroughVariant3BaseType
    {
        /// <summary>
        ///
        /// </summary>
        Entity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared1e1af2b60dfcf13aFallthroughVariant3BaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared1e1af2b60dfcf13aFallthroughVariant3BaseType value)
        {
            return value switch
            {
                AutoSDKShared1e1af2b60dfcf13aFallthroughVariant3BaseType.Entity => "entity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared1e1af2b60dfcf13aFallthroughVariant3BaseType? ToEnum(string value)
        {
            return value switch
            {
                "entity" => AutoSDKShared1e1af2b60dfcf13aFallthroughVariant3BaseType.Entity,
                _ => null,
            };
        }
    }
}