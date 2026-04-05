
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum FlagExperimentStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Closed,
        /// <summary>
        /// 
        /// </summary>
        Draft,
        /// <summary>
        /// 
        /// </summary>
        Paused,
        /// <summary>
        /// 
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FlagExperimentStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FlagExperimentStatus value)
        {
            return value switch
            {
                FlagExperimentStatus.Closed => "closed",
                FlagExperimentStatus.Draft => "draft",
                FlagExperimentStatus.Paused => "paused",
                FlagExperimentStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FlagExperimentStatus? ToEnum(string value)
        {
            return value switch
            {
                "closed" => FlagExperimentStatus.Closed,
                "draft" => FlagExperimentStatus.Draft,
                "paused" => FlagExperimentStatus.Paused,
                "running" => FlagExperimentStatus.Running,
                _ => null,
            };
        }
    }
}