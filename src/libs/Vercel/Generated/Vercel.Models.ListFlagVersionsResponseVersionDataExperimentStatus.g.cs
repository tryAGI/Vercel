
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListFlagVersionsResponseVersionDataExperimentStatus
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
    public static class ListFlagVersionsResponseVersionDataExperimentStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListFlagVersionsResponseVersionDataExperimentStatus value)
        {
            return value switch
            {
                ListFlagVersionsResponseVersionDataExperimentStatus.Closed => "closed",
                ListFlagVersionsResponseVersionDataExperimentStatus.Draft => "draft",
                ListFlagVersionsResponseVersionDataExperimentStatus.Paused => "paused",
                ListFlagVersionsResponseVersionDataExperimentStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListFlagVersionsResponseVersionDataExperimentStatus? ToEnum(string value)
        {
            return value switch
            {
                "closed" => ListFlagVersionsResponseVersionDataExperimentStatus.Closed,
                "draft" => ListFlagVersionsResponseVersionDataExperimentStatus.Draft,
                "paused" => ListFlagVersionsResponseVersionDataExperimentStatus.Paused,
                "running" => ListFlagVersionsResponseVersionDataExperimentStatus.Running,
                _ => null,
            };
        }
    }
}