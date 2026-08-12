
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Principal type of the deployment creator.
    /// </summary>
    public enum CreateDeploymentResponseVariant2CreatorType
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
    public static class CreateDeploymentResponseVariant2CreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseVariant2CreatorType value)
        {
            return value switch
            {
                CreateDeploymentResponseVariant2CreatorType.App => "app",
                CreateDeploymentResponseVariant2CreatorType.Integration => "integration",
                CreateDeploymentResponseVariant2CreatorType.System => "system",
                CreateDeploymentResponseVariant2CreatorType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseVariant2CreatorType? ToEnum(string value)
        {
            return value switch
            {
                "app" => CreateDeploymentResponseVariant2CreatorType.App,
                "integration" => CreateDeploymentResponseVariant2CreatorType.Integration,
                "system" => CreateDeploymentResponseVariant2CreatorType.System,
                "user" => CreateDeploymentResponseVariant2CreatorType.User,
                _ => null,
            };
        }
    }
}