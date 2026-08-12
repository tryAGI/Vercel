
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Principal type of the deployment creator.
    /// </summary>
    public enum GetDeploymentResponseVariant2CreatorType
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
    public static class GetDeploymentResponseVariant2CreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant2CreatorType value)
        {
            return value switch
            {
                GetDeploymentResponseVariant2CreatorType.App => "app",
                GetDeploymentResponseVariant2CreatorType.Integration => "integration",
                GetDeploymentResponseVariant2CreatorType.System => "system",
                GetDeploymentResponseVariant2CreatorType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant2CreatorType? ToEnum(string value)
        {
            return value switch
            {
                "app" => GetDeploymentResponseVariant2CreatorType.App,
                "integration" => GetDeploymentResponseVariant2CreatorType.Integration,
                "system" => GetDeploymentResponseVariant2CreatorType.System,
                "user" => GetDeploymentResponseVariant2CreatorType.User,
                _ => null,
            };
        }
    }
}