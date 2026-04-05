
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentCheckRunResponseStatus
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
    public static class GetDeploymentCheckRunResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentCheckRunResponseStatus value)
        {
            return value switch
            {
                GetDeploymentCheckRunResponseStatus.Completed => "completed",
                GetDeploymentCheckRunResponseStatus.Queued => "queued",
                GetDeploymentCheckRunResponseStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentCheckRunResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => GetDeploymentCheckRunResponseStatus.Completed,
                "queued" => GetDeploymentCheckRunResponseStatus.Queued,
                "running" => GetDeploymentCheckRunResponseStatus.Running,
                _ => null,
            };
        }
    }
}