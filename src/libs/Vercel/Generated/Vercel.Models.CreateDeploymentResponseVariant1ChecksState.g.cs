
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseVariant1ChecksState
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
    public static class CreateDeploymentResponseVariant1ChecksStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseVariant1ChecksState value)
        {
            return value switch
            {
                CreateDeploymentResponseVariant1ChecksState.Completed => "completed",
                CreateDeploymentResponseVariant1ChecksState.Registered => "registered",
                CreateDeploymentResponseVariant1ChecksState.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseVariant1ChecksState? ToEnum(string value)
        {
            return value switch
            {
                "completed" => CreateDeploymentResponseVariant1ChecksState.Completed,
                "registered" => CreateDeploymentResponseVariant1ChecksState.Registered,
                "running" => CreateDeploymentResponseVariant1ChecksState.Running,
                _ => null,
            };
        }
    }
}