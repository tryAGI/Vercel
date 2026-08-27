
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateProjectResponseAliaDeploymentChecksState
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
    public static class CreateProjectResponseAliaDeploymentChecksStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseAliaDeploymentChecksState value)
        {
            return value switch
            {
                CreateProjectResponseAliaDeploymentChecksState.Completed => "completed",
                CreateProjectResponseAliaDeploymentChecksState.Registered => "registered",
                CreateProjectResponseAliaDeploymentChecksState.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseAliaDeploymentChecksState? ToEnum(string value)
        {
            return value switch
            {
                "completed" => CreateProjectResponseAliaDeploymentChecksState.Completed,
                "registered" => CreateProjectResponseAliaDeploymentChecksState.Registered,
                "running" => CreateProjectResponseAliaDeploymentChecksState.Running,
                _ => null,
            };
        }
    }
}