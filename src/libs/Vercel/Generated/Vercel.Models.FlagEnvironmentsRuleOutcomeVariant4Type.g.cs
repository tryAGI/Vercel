
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum FlagEnvironmentsRuleOutcomeVariant4Type
    {
        /// <summary>
        ///
        /// </summary>
        Experiment,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FlagEnvironmentsRuleOutcomeVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FlagEnvironmentsRuleOutcomeVariant4Type value)
        {
            return value switch
            {
                FlagEnvironmentsRuleOutcomeVariant4Type.Experiment => "experiment",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FlagEnvironmentsRuleOutcomeVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "experiment" => FlagEnvironmentsRuleOutcomeVariant4Type.Experiment,
                _ => null,
            };
        }
    }
}