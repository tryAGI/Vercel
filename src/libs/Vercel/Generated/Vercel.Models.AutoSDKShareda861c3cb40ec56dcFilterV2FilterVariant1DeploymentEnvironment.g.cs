
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda861c3cb40ec56dcFilterV2FilterVariant1DeploymentEnvironment
    {
        /// <summary>
        ///
        /// </summary>
        Preview,
        /// <summary>
        ///
        /// </summary>
        Production,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShareda861c3cb40ec56dcFilterV2FilterVariant1DeploymentEnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda861c3cb40ec56dcFilterV2FilterVariant1DeploymentEnvironment value)
        {
            return value switch
            {
                AutoSDKShareda861c3cb40ec56dcFilterV2FilterVariant1DeploymentEnvironment.Preview => "preview",
                AutoSDKShareda861c3cb40ec56dcFilterV2FilterVariant1DeploymentEnvironment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda861c3cb40ec56dcFilterV2FilterVariant1DeploymentEnvironment? ToEnum(string value)
        {
            return value switch
            {
                "preview" => AutoSDKShareda861c3cb40ec56dcFilterV2FilterVariant1DeploymentEnvironment.Preview,
                "production" => AutoSDKShareda861c3cb40ec56dcFilterV2FilterVariant1DeploymentEnvironment.Production,
                _ => null,
            };
        }
    }
}