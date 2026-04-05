
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseChecksState
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
    public static class CreateDeploymentResponseChecksStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseChecksState value)
        {
            return value switch
            {
                CreateDeploymentResponseChecksState.Completed => "completed",
                CreateDeploymentResponseChecksState.Registered => "registered",
                CreateDeploymentResponseChecksState.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseChecksState? ToEnum(string value)
        {
            return value switch
            {
                "completed" => CreateDeploymentResponseChecksState.Completed,
                "registered" => CreateDeploymentResponseChecksState.Registered,
                "running" => CreateDeploymentResponseChecksState.Running,
                _ => null,
            };
        }
    }
}