
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentResponseVariant1ChecksState
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
    public static class GetDeploymentResponseVariant1ChecksStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant1ChecksState value)
        {
            return value switch
            {
                GetDeploymentResponseVariant1ChecksState.Completed => "completed",
                GetDeploymentResponseVariant1ChecksState.Registered => "registered",
                GetDeploymentResponseVariant1ChecksState.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant1ChecksState? ToEnum(string value)
        {
            return value switch
            {
                "completed" => GetDeploymentResponseVariant1ChecksState.Completed,
                "registered" => GetDeploymentResponseVariant1ChecksState.Registered,
                "running" => GetDeploymentResponseVariant1ChecksState.Running,
                _ => null,
            };
        }
    }
}