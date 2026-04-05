
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateFlagResponseEnvironmentsRuleConditionRhsVariant4Type
    {
        /// <summary>
        /// 
        /// </summary>
        Regex,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateFlagResponseEnvironmentsRuleConditionRhsVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateFlagResponseEnvironmentsRuleConditionRhsVariant4Type value)
        {
            return value switch
            {
                CreateFlagResponseEnvironmentsRuleConditionRhsVariant4Type.Regex => "regex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateFlagResponseEnvironmentsRuleConditionRhsVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "regex" => CreateFlagResponseEnvironmentsRuleConditionRhsVariant4Type.Regex,
                _ => null,
            };
        }
    }
}