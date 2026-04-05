
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateFlagResponseExperimentGuardrailMetricDirectionality
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
    public static class CreateFlagResponseExperimentGuardrailMetricDirectionalityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateFlagResponseExperimentGuardrailMetricDirectionality value)
        {
            return value switch
            {
                CreateFlagResponseExperimentGuardrailMetricDirectionality.DecreaseIsGood => "decreaseIsGood",
                CreateFlagResponseExperimentGuardrailMetricDirectionality.IncreaseIsGood => "increaseIsGood",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateFlagResponseExperimentGuardrailMetricDirectionality? ToEnum(string value)
        {
            return value switch
            {
                "decreaseIsGood" => CreateFlagResponseExperimentGuardrailMetricDirectionality.DecreaseIsGood,
                "increaseIsGood" => CreateFlagResponseExperimentGuardrailMetricDirectionality.IncreaseIsGood,
                _ => null,
            };
        }
    }
}