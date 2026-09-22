
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0f637bb8b5caf2d6RuleConditionLhsVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        Entity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared0f637bb8b5caf2d6RuleConditionLhsVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0f637bb8b5caf2d6RuleConditionLhsVariant2Type value)
        {
            return value switch
            {
                AutoSDKShared0f637bb8b5caf2d6RuleConditionLhsVariant2Type.Entity => "entity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0f637bb8b5caf2d6RuleConditionLhsVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "entity" => AutoSDKShared0f637bb8b5caf2d6RuleConditionLhsVariant2Type.Entity,
                _ => null,
            };
        }
    }
}