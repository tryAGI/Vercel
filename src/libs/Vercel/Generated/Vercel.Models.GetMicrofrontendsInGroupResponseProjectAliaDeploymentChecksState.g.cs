
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectAliaDeploymentChecksState
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
    public static class GetMicrofrontendsInGroupResponseProjectAliaDeploymentChecksStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectAliaDeploymentChecksState value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectAliaDeploymentChecksState.Completed => "completed",
                GetMicrofrontendsInGroupResponseProjectAliaDeploymentChecksState.Registered => "registered",
                GetMicrofrontendsInGroupResponseProjectAliaDeploymentChecksState.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectAliaDeploymentChecksState? ToEnum(string value)
        {
            return value switch
            {
                "completed" => GetMicrofrontendsInGroupResponseProjectAliaDeploymentChecksState.Completed,
                "registered" => GetMicrofrontendsInGroupResponseProjectAliaDeploymentChecksState.Registered,
                "running" => GetMicrofrontendsInGroupResponseProjectAliaDeploymentChecksState.Running,
                _ => null,
            };
        }
    }
}