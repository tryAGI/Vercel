
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedd9e46425f35715a0OutcomeVariant3BaseType
    {
        /// <summary>
        ///
        /// </summary>
        Entity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedd9e46425f35715a0OutcomeVariant3BaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedd9e46425f35715a0OutcomeVariant3BaseType value)
        {
            return value switch
            {
                AutoSDKSharedd9e46425f35715a0OutcomeVariant3BaseType.Entity => "entity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedd9e46425f35715a0OutcomeVariant3BaseType? ToEnum(string value)
        {
            return value switch
            {
                "entity" => AutoSDKSharedd9e46425f35715a0OutcomeVariant3BaseType.Entity,
                _ => null,
            };
        }
    }
}