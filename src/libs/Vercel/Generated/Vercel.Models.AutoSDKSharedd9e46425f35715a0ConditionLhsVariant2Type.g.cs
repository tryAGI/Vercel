
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedd9e46425f35715a0ConditionLhsVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        Entity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedd9e46425f35715a0ConditionLhsVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedd9e46425f35715a0ConditionLhsVariant2Type value)
        {
            return value switch
            {
                AutoSDKSharedd9e46425f35715a0ConditionLhsVariant2Type.Entity => "entity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedd9e46425f35715a0ConditionLhsVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "entity" => AutoSDKSharedd9e46425f35715a0ConditionLhsVariant2Type.Entity,
                _ => null,
            };
        }
    }
}