
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CancelDeploymentResponseChecksState
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Registered,
        /// <summary>
        /// 
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CancelDeploymentResponseChecksStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseChecksState value)
        {
            return value switch
            {
                CancelDeploymentResponseChecksState.Completed => "completed",
                CancelDeploymentResponseChecksState.Registered => "registered",
                CancelDeploymentResponseChecksState.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseChecksState? ToEnum(string value)
        {
            return value switch
            {
                "completed" => CancelDeploymentResponseChecksState.Completed,
                "registered" => CancelDeploymentResponseChecksState.Registered,
                "running" => CancelDeploymentResponseChecksState.Running,
                _ => null,
            };
        }
    }
}