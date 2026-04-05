
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListFlagVersionsResponseVersionDataExperimentPrimaryMetricDirectionality
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
    public static class ListFlagVersionsResponseVersionDataExperimentPrimaryMetricDirectionalityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListFlagVersionsResponseVersionDataExperimentPrimaryMetricDirectionality value)
        {
            return value switch
            {
                ListFlagVersionsResponseVersionDataExperimentPrimaryMetricDirectionality.DecreaseIsGood => "decreaseIsGood",
                ListFlagVersionsResponseVersionDataExperimentPrimaryMetricDirectionality.IncreaseIsGood => "increaseIsGood",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListFlagVersionsResponseVersionDataExperimentPrimaryMetricDirectionality? ToEnum(string value)
        {
            return value switch
            {
                "decreaseIsGood" => ListFlagVersionsResponseVersionDataExperimentPrimaryMetricDirectionality.DecreaseIsGood,
                "increaseIsGood" => ListFlagVersionsResponseVersionDataExperimentPrimaryMetricDirectionality.IncreaseIsGood,
                _ => null,
            };
        }
    }
}