
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentResponseVariant2ChecksState
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
    public static class GetDeploymentResponseVariant2ChecksStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant2ChecksState value)
        {
            return value switch
            {
                GetDeploymentResponseVariant2ChecksState.Completed => "completed",
                GetDeploymentResponseVariant2ChecksState.Registered => "registered",
                GetDeploymentResponseVariant2ChecksState.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant2ChecksState? ToEnum(string value)
        {
            return value switch
            {
                "completed" => GetDeploymentResponseVariant2ChecksState.Completed,
                "registered" => GetDeploymentResponseVariant2ChecksState.Registered,
                "running" => GetDeploymentResponseVariant2ChecksState.Running,
                _ => null,
            };
        }
    }
}