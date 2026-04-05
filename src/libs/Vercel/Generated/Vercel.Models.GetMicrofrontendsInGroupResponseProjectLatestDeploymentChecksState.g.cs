
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectLatestDeploymentChecksState
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
    public static class GetMicrofrontendsInGroupResponseProjectLatestDeploymentChecksStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectLatestDeploymentChecksState value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectLatestDeploymentChecksState.Completed => "completed",
                GetMicrofrontendsInGroupResponseProjectLatestDeploymentChecksState.Registered => "registered",
                GetMicrofrontendsInGroupResponseProjectLatestDeploymentChecksState.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectLatestDeploymentChecksState? ToEnum(string value)
        {
            return value switch
            {
                "completed" => GetMicrofrontendsInGroupResponseProjectLatestDeploymentChecksState.Completed,
                "registered" => GetMicrofrontendsInGroupResponseProjectLatestDeploymentChecksState.Registered,
                "running" => GetMicrofrontendsInGroupResponseProjectLatestDeploymentChecksState.Running,
                _ => null,
            };
        }
    }
}