
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentCheckRunResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentCheckRunResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentCheckRunResponseStatus value)
        {
            return value switch
            {
                CreateDeploymentCheckRunResponseStatus.Completed => "completed",
                CreateDeploymentCheckRunResponseStatus.Queued => "queued",
                CreateDeploymentCheckRunResponseStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentCheckRunResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => CreateDeploymentCheckRunResponseStatus.Completed,
                "queued" => CreateDeploymentCheckRunResponseStatus.Queued,
                "running" => CreateDeploymentCheckRunResponseStatus.Running,
                _ => null,
            };
        }
    }
}