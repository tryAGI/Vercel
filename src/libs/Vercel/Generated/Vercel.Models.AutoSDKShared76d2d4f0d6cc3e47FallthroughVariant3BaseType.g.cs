
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared76d2d4f0d6cc3e47FallthroughVariant3BaseType
    {
        /// <summary>
        ///
        /// </summary>
        Entity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared76d2d4f0d6cc3e47FallthroughVariant3BaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared76d2d4f0d6cc3e47FallthroughVariant3BaseType value)
        {
            return value switch
            {
                AutoSDKShared76d2d4f0d6cc3e47FallthroughVariant3BaseType.Entity => "entity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared76d2d4f0d6cc3e47FallthroughVariant3BaseType? ToEnum(string value)
        {
            return value switch
            {
                "entity" => AutoSDKShared76d2d4f0d6cc3e47FallthroughVariant3BaseType.Entity,
                _ => null,
            };
        }
    }
}