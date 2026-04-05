
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateFlagResponseExperimentPrimaryMetricDirectionality
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
    public static class CreateFlagResponseExperimentPrimaryMetricDirectionalityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateFlagResponseExperimentPrimaryMetricDirectionality value)
        {
            return value switch
            {
                CreateFlagResponseExperimentPrimaryMetricDirectionality.DecreaseIsGood => "decreaseIsGood",
                CreateFlagResponseExperimentPrimaryMetricDirectionality.IncreaseIsGood => "increaseIsGood",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateFlagResponseExperimentPrimaryMetricDirectionality? ToEnum(string value)
        {
            return value switch
            {
                "decreaseIsGood" => CreateFlagResponseExperimentPrimaryMetricDirectionality.DecreaseIsGood,
                "increaseIsGood" => CreateFlagResponseExperimentPrimaryMetricDirectionality.IncreaseIsGood,
                _ => null,
            };
        }
    }
}