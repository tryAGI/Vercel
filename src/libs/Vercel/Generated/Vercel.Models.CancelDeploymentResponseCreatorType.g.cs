
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Principal type of the deployment creator.
    /// </summary>
    public enum CancelDeploymentResponseCreatorType
    {
        /// <summary>
        ///
        /// </summary>
        App,
        /// <summary>
        ///
        /// </summary>
        Integration,
        /// <summary>
        ///
        /// </summary>
        Project,
        /// <summary>
        ///
        /// </summary>
        System,
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CancelDeploymentResponseCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseCreatorType value)
        {
            return value switch
            {
                CancelDeploymentResponseCreatorType.App => "app",
                CancelDeploymentResponseCreatorType.Integration => "integration",
                CancelDeploymentResponseCreatorType.Project => "project",
                CancelDeploymentResponseCreatorType.System => "system",
                CancelDeploymentResponseCreatorType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "app" => CancelDeploymentResponseCreatorType.App,
                "integration" => CancelDeploymentResponseCreatorType.Integration,
                "project" => CancelDeploymentResponseCreatorType.Project,
                "system" => CancelDeploymentResponseCreatorType.System,
                "user" => CancelDeploymentResponseCreatorType.User,
                _ => null,
            };
        }
    }
}