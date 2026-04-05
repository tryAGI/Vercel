
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFlagResponseExperimentStatus
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
    public static class UpdateFlagResponseExperimentStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFlagResponseExperimentStatus value)
        {
            return value switch
            {
                UpdateFlagResponseExperimentStatus.Closed => "closed",
                UpdateFlagResponseExperimentStatus.Draft => "draft",
                UpdateFlagResponseExperimentStatus.Paused => "paused",
                UpdateFlagResponseExperimentStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFlagResponseExperimentStatus? ToEnum(string value)
        {
            return value switch
            {
                "closed" => UpdateFlagResponseExperimentStatus.Closed,
                "draft" => UpdateFlagResponseExperimentStatus.Draft,
                "paused" => UpdateFlagResponseExperimentStatus.Paused,
                "running" => UpdateFlagResponseExperimentStatus.Running,
                _ => null,
            };
        }
    }
}