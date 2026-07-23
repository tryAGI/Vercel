
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentResponseVariant3ChecksState
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
    public static class GetDeploymentResponseVariant3ChecksStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant3ChecksState value)
        {
            return value switch
            {
                GetDeploymentResponseVariant3ChecksState.Completed => "completed",
                GetDeploymentResponseVariant3ChecksState.Registered => "registered",
                GetDeploymentResponseVariant3ChecksState.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant3ChecksState? ToEnum(string value)
        {
            return value switch
            {
                "completed" => GetDeploymentResponseVariant3ChecksState.Completed,
                "registered" => GetDeploymentResponseVariant3ChecksState.Registered,
                "running" => GetDeploymentResponseVariant3ChecksState.Running,
                _ => null,
            };
        }
    }
}