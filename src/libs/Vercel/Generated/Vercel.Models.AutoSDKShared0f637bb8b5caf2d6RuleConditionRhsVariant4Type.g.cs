
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0f637bb8b5caf2d6RuleConditionRhsVariant4Type
    {
        /// <summary>
        ///
        /// </summary>
        Regex,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared0f637bb8b5caf2d6RuleConditionRhsVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0f637bb8b5caf2d6RuleConditionRhsVariant4Type value)
        {
            return value switch
            {
                AutoSDKShared0f637bb8b5caf2d6RuleConditionRhsVariant4Type.Regex => "regex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0f637bb8b5caf2d6RuleConditionRhsVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "regex" => AutoSDKShared0f637bb8b5caf2d6RuleConditionRhsVariant4Type.Regex,
                _ => null,
            };
        }
    }
}