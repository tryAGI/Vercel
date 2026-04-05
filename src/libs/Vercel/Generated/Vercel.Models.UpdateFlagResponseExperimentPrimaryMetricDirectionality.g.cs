
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFlagResponseExperimentPrimaryMetricDirectionality
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
    public static class UpdateFlagResponseExperimentPrimaryMetricDirectionalityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFlagResponseExperimentPrimaryMetricDirectionality value)
        {
            return value switch
            {
                UpdateFlagResponseExperimentPrimaryMetricDirectionality.DecreaseIsGood => "decreaseIsGood",
                UpdateFlagResponseExperimentPrimaryMetricDirectionality.IncreaseIsGood => "increaseIsGood",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFlagResponseExperimentPrimaryMetricDirectionality? ToEnum(string value)
        {
            return value switch
            {
                "decreaseIsGood" => UpdateFlagResponseExperimentPrimaryMetricDirectionality.DecreaseIsGood,
                "increaseIsGood" => UpdateFlagResponseExperimentPrimaryMetricDirectionality.IncreaseIsGood,
                _ => null,
            };
        }
    }
}