
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum FlagExperimentGuardrailMetricDirectionality
    {
        /// <summary>
        /// 
        /// </summary>
        DecreaseIsGood,
        /// <summary>
        /// 
        /// </summary>
        IncreaseIsGood,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FlagExperimentGuardrailMetricDirectionalityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FlagExperimentGuardrailMetricDirectionality value)
        {
            return value switch
            {
                FlagExperimentGuardrailMetricDirectionality.DecreaseIsGood => "decreaseIsGood",
                FlagExperimentGuardrailMetricDirectionality.IncreaseIsGood => "increaseIsGood",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FlagExperimentGuardrailMetricDirectionality? ToEnum(string value)
        {
            return value switch
            {
                "decreaseIsGood" => FlagExperimentGuardrailMetricDirectionality.DecreaseIsGood,
                "increaseIsGood" => FlagExperimentGuardrailMetricDirectionality.IncreaseIsGood,
                _ => null,
            };
        }
    }
}