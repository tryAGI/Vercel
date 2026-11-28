
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedce53ae034203eae7OutcomeVariant2BaseType
    {
        /// <summary>
        ///
        /// </summary>
        Entity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedce53ae034203eae7OutcomeVariant2BaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedce53ae034203eae7OutcomeVariant2BaseType value)
        {
            return value switch
            {
                AutoSDKSharedce53ae034203eae7OutcomeVariant2BaseType.Entity => "entity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedce53ae034203eae7OutcomeVariant2BaseType? ToEnum(string value)
        {
            return value switch
            {
                "entity" => AutoSDKSharedce53ae034203eae7OutcomeVariant2BaseType.Entity,
                _ => null,
            };
        }
    }
}