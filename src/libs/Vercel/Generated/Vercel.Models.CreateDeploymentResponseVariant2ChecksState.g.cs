
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateDeploymentResponseVariant2ChecksState
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
    public static class CreateDeploymentResponseVariant2ChecksStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseVariant2ChecksState value)
        {
            return value switch
            {
                CreateDeploymentResponseVariant2ChecksState.Completed => "completed",
                CreateDeploymentResponseVariant2ChecksState.Registered => "registered",
                CreateDeploymentResponseVariant2ChecksState.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseVariant2ChecksState? ToEnum(string value)
        {
            return value switch
            {
                "completed" => CreateDeploymentResponseVariant2ChecksState.Completed,
                "registered" => CreateDeploymentResponseVariant2ChecksState.Registered,
                "running" => CreateDeploymentResponseVariant2ChecksState.Running,
                _ => null,
            };
        }
    }
}