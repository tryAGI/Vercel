
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFlagResponseEnvironmentsRuleOutcomeVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        Rollout,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateFlagResponseEnvironmentsRuleOutcomeVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFlagResponseEnvironmentsRuleOutcomeVariant3Type value)
        {
            return value switch
            {
                UpdateFlagResponseEnvironmentsRuleOutcomeVariant3Type.Rollout => "rollout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFlagResponseEnvironmentsRuleOutcomeVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "rollout" => UpdateFlagResponseEnvironmentsRuleOutcomeVariant3Type.Rollout,
                _ => null,
            };
        }
    }
}