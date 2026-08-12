
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Principal type of the deployment creator.
    /// </summary>
    public enum GetDeploymentResponseVariant3CreatorType
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
    public static class GetDeploymentResponseVariant3CreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant3CreatorType value)
        {
            return value switch
            {
                GetDeploymentResponseVariant3CreatorType.App => "app",
                GetDeploymentResponseVariant3CreatorType.Integration => "integration",
                GetDeploymentResponseVariant3CreatorType.System => "system",
                GetDeploymentResponseVariant3CreatorType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant3CreatorType? ToEnum(string value)
        {
            return value switch
            {
                "app" => GetDeploymentResponseVariant3CreatorType.App,
                "integration" => GetDeploymentResponseVariant3CreatorType.Integration,
                "system" => GetDeploymentResponseVariant3CreatorType.System,
                "user" => GetDeploymentResponseVariant3CreatorType.User,
                _ => null,
            };
        }
    }
}