
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateMicrofrontendsResponseLatestDeploymentChecksState
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
    public static class UpdateMicrofrontendsResponseLatestDeploymentChecksStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseLatestDeploymentChecksState value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseLatestDeploymentChecksState.Completed => "completed",
                UpdateMicrofrontendsResponseLatestDeploymentChecksState.Registered => "registered",
                UpdateMicrofrontendsResponseLatestDeploymentChecksState.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseLatestDeploymentChecksState? ToEnum(string value)
        {
            return value switch
            {
                "completed" => UpdateMicrofrontendsResponseLatestDeploymentChecksState.Completed,
                "registered" => UpdateMicrofrontendsResponseLatestDeploymentChecksState.Registered,
                "running" => UpdateMicrofrontendsResponseLatestDeploymentChecksState.Running,
                _ => null,
            };
        }
    }
}