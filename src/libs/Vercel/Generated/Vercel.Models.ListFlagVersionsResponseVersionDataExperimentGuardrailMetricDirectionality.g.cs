
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListFlagVersionsResponseVersionDataExperimentGuardrailMetricDirectionality
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
    public static class ListFlagVersionsResponseVersionDataExperimentGuardrailMetricDirectionalityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListFlagVersionsResponseVersionDataExperimentGuardrailMetricDirectionality value)
        {
            return value switch
            {
                ListFlagVersionsResponseVersionDataExperimentGuardrailMetricDirectionality.DecreaseIsGood => "decreaseIsGood",
                ListFlagVersionsResponseVersionDataExperimentGuardrailMetricDirectionality.IncreaseIsGood => "increaseIsGood",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListFlagVersionsResponseVersionDataExperimentGuardrailMetricDirectionality? ToEnum(string value)
        {
            return value switch
            {
                "decreaseIsGood" => ListFlagVersionsResponseVersionDataExperimentGuardrailMetricDirectionality.DecreaseIsGood,
                "increaseIsGood" => ListFlagVersionsResponseVersionDataExperimentGuardrailMetricDirectionality.IncreaseIsGood,
                _ => null,
            };
        }
    }
}