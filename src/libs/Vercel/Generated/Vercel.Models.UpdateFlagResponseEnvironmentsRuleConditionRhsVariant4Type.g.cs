
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFlagResponseEnvironmentsRuleConditionRhsVariant4Type
    {
        /// <summary>
        /// 
        /// </summary>
        Regex,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateFlagResponseEnvironmentsRuleConditionRhsVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFlagResponseEnvironmentsRuleConditionRhsVariant4Type value)
        {
            return value switch
            {
                UpdateFlagResponseEnvironmentsRuleConditionRhsVariant4Type.Regex => "regex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFlagResponseEnvironmentsRuleConditionRhsVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "regex" => UpdateFlagResponseEnvironmentsRuleConditionRhsVariant4Type.Regex,
                _ => null,
            };
        }
    }
}