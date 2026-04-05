
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateFlagResponseExperimentStatus
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
    public static class CreateFlagResponseExperimentStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateFlagResponseExperimentStatus value)
        {
            return value switch
            {
                CreateFlagResponseExperimentStatus.Closed => "closed",
                CreateFlagResponseExperimentStatus.Draft => "draft",
                CreateFlagResponseExperimentStatus.Paused => "paused",
                CreateFlagResponseExperimentStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateFlagResponseExperimentStatus? ToEnum(string value)
        {
            return value switch
            {
                "closed" => CreateFlagResponseExperimentStatus.Closed,
                "draft" => CreateFlagResponseExperimentStatus.Draft,
                "paused" => CreateFlagResponseExperimentStatus.Paused,
                "running" => CreateFlagResponseExperimentStatus.Running,
                _ => null,
            };
        }
    }
}