
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0f637bb8b5caf2d6RuleConditionLhsVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        Segment,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared0f637bb8b5caf2d6RuleConditionLhsVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0f637bb8b5caf2d6RuleConditionLhsVariant1Type value)
        {
            return value switch
            {
                AutoSDKShared0f637bb8b5caf2d6RuleConditionLhsVariant1Type.Segment => "segment",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0f637bb8b5caf2d6RuleConditionLhsVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "segment" => AutoSDKShared0f637bb8b5caf2d6RuleConditionLhsVariant1Type.Segment,
                _ => null,
            };
        }
    }
}