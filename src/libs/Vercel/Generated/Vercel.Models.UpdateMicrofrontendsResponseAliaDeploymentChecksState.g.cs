
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateMicrofrontendsResponseAliaDeploymentChecksState
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
    public static class UpdateMicrofrontendsResponseAliaDeploymentChecksStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseAliaDeploymentChecksState value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseAliaDeploymentChecksState.Completed => "completed",
                UpdateMicrofrontendsResponseAliaDeploymentChecksState.Registered => "registered",
                UpdateMicrofrontendsResponseAliaDeploymentChecksState.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseAliaDeploymentChecksState? ToEnum(string value)
        {
            return value switch
            {
                "completed" => UpdateMicrofrontendsResponseAliaDeploymentChecksState.Completed,
                "registered" => UpdateMicrofrontendsResponseAliaDeploymentChecksState.Registered,
                "running" => UpdateMicrofrontendsResponseAliaDeploymentChecksState.Running,
                _ => null,
            };
        }
    }
}