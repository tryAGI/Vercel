
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared9f8c0585e20078fcFilterV2FilterVariant1DeploymentEnvironment
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
    public static class AutoSDKShared9f8c0585e20078fcFilterV2FilterVariant1DeploymentEnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared9f8c0585e20078fcFilterV2FilterVariant1DeploymentEnvironment value)
        {
            return value switch
            {
                AutoSDKShared9f8c0585e20078fcFilterV2FilterVariant1DeploymentEnvironment.Preview => "preview",
                AutoSDKShared9f8c0585e20078fcFilterV2FilterVariant1DeploymentEnvironment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared9f8c0585e20078fcFilterV2FilterVariant1DeploymentEnvironment? ToEnum(string value)
        {
            return value switch
            {
                "preview" => AutoSDKShared9f8c0585e20078fcFilterV2FilterVariant1DeploymentEnvironment.Preview,
                "production" => AutoSDKShared9f8c0585e20078fcFilterV2FilterVariant1DeploymentEnvironment.Production,
                _ => null,
            };
        }
    }
}