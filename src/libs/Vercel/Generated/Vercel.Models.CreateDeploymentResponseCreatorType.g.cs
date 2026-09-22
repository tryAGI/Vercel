
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Principal type of the deployment creator.
    /// </summary>
    public enum CreateDeploymentResponseCreatorType
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
        System,
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentResponseCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseCreatorType value)
        {
            return value switch
            {
                CreateDeploymentResponseCreatorType.App => "app",
                CreateDeploymentResponseCreatorType.Integration => "integration",
                CreateDeploymentResponseCreatorType.System => "system",
                CreateDeploymentResponseCreatorType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "app" => CreateDeploymentResponseCreatorType.App,
                "integration" => CreateDeploymentResponseCreatorType.Integration,
                "system" => CreateDeploymentResponseCreatorType.System,
                "user" => CreateDeploymentResponseCreatorType.User,
                _ => null,
            };
        }
    }
}