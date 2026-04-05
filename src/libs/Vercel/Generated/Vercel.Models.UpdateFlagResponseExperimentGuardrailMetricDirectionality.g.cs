
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFlagResponseExperimentGuardrailMetricDirectionality
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
    public static class UpdateFlagResponseExperimentGuardrailMetricDirectionalityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFlagResponseExperimentGuardrailMetricDirectionality value)
        {
            return value switch
            {
                UpdateFlagResponseExperimentGuardrailMetricDirectionality.DecreaseIsGood => "decreaseIsGood",
                UpdateFlagResponseExperimentGuardrailMetricDirectionality.IncreaseIsGood => "increaseIsGood",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFlagResponseExperimentGuardrailMetricDirectionality? ToEnum(string value)
        {
            return value switch
            {
                "decreaseIsGood" => UpdateFlagResponseExperimentGuardrailMetricDirectionality.DecreaseIsGood,
                "increaseIsGood" => UpdateFlagResponseExperimentGuardrailMetricDirectionality.IncreaseIsGood,
                _ => null,
            };
        }
    }
}