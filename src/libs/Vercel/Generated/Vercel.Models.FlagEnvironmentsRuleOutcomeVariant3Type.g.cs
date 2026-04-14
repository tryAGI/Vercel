
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum FlagEnvironmentsRuleOutcomeVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        Rollout,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FlagEnvironmentsRuleOutcomeVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FlagEnvironmentsRuleOutcomeVariant3Type value)
        {
            return value switch
            {
                FlagEnvironmentsRuleOutcomeVariant3Type.Rollout => "rollout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FlagEnvironmentsRuleOutcomeVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "rollout" => FlagEnvironmentsRuleOutcomeVariant3Type.Rollout,
                _ => null,
            };
        }
    }
}