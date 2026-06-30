
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant1ItemAliaDeploymentChecksState
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
    public static class GetProjectsResponseVariant1ItemAliaDeploymentChecksStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemAliaDeploymentChecksState value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemAliaDeploymentChecksState.Completed => "completed",
                GetProjectsResponseVariant1ItemAliaDeploymentChecksState.Registered => "registered",
                GetProjectsResponseVariant1ItemAliaDeploymentChecksState.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemAliaDeploymentChecksState? ToEnum(string value)
        {
            return value switch
            {
                "completed" => GetProjectsResponseVariant1ItemAliaDeploymentChecksState.Completed,
                "registered" => GetProjectsResponseVariant1ItemAliaDeploymentChecksState.Registered,
                "running" => GetProjectsResponseVariant1ItemAliaDeploymentChecksState.Running,
                _ => null,
            };
        }
    }
}