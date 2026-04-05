
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum FlagExperimentPrimaryMetricDirectionality
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
    public static class FlagExperimentPrimaryMetricDirectionalityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FlagExperimentPrimaryMetricDirectionality value)
        {
            return value switch
            {
                FlagExperimentPrimaryMetricDirectionality.DecreaseIsGood => "decreaseIsGood",
                FlagExperimentPrimaryMetricDirectionality.IncreaseIsGood => "increaseIsGood",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FlagExperimentPrimaryMetricDirectionality? ToEnum(string value)
        {
            return value switch
            {
                "decreaseIsGood" => FlagExperimentPrimaryMetricDirectionality.DecreaseIsGood,
                "increaseIsGood" => FlagExperimentPrimaryMetricDirectionality.IncreaseIsGood,
                _ => null,
            };
        }
    }
}