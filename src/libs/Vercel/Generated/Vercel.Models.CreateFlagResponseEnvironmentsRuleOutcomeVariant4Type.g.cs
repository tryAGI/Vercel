
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateFlagResponseEnvironmentsRuleOutcomeVariant4Type
    {
        /// <summary>
        /// 
        /// </summary>
        Experiment,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateFlagResponseEnvironmentsRuleOutcomeVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateFlagResponseEnvironmentsRuleOutcomeVariant4Type value)
        {
            return value switch
            {
                CreateFlagResponseEnvironmentsRuleOutcomeVariant4Type.Experiment => "experiment",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateFlagResponseEnvironmentsRuleOutcomeVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "experiment" => CreateFlagResponseEnvironmentsRuleOutcomeVariant4Type.Experiment,
                _ => null,
            };
        }
    }
}