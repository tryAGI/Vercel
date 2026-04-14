
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateFlagResponseEnvironmentsRuleOutcomeVariant3BaseType
    {
        /// <summary>
        /// 
        /// </summary>
        Entity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateFlagResponseEnvironmentsRuleOutcomeVariant3BaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateFlagResponseEnvironmentsRuleOutcomeVariant3BaseType value)
        {
            return value switch
            {
                CreateFlagResponseEnvironmentsRuleOutcomeVariant3BaseType.Entity => "entity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateFlagResponseEnvironmentsRuleOutcomeVariant3BaseType? ToEnum(string value)
        {
            return value switch
            {
                "entity" => CreateFlagResponseEnvironmentsRuleOutcomeVariant3BaseType.Entity,
                _ => null,
            };
        }
    }
}