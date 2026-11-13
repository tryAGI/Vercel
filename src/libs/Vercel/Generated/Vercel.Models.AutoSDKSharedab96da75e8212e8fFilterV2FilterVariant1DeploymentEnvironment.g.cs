
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedab96da75e8212e8fFilterV2FilterVariant1DeploymentEnvironment
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
    public static class AutoSDKSharedab96da75e8212e8fFilterV2FilterVariant1DeploymentEnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedab96da75e8212e8fFilterV2FilterVariant1DeploymentEnvironment value)
        {
            return value switch
            {
                AutoSDKSharedab96da75e8212e8fFilterV2FilterVariant1DeploymentEnvironment.Preview => "preview",
                AutoSDKSharedab96da75e8212e8fFilterV2FilterVariant1DeploymentEnvironment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedab96da75e8212e8fFilterV2FilterVariant1DeploymentEnvironment? ToEnum(string value)
        {
            return value switch
            {
                "preview" => AutoSDKSharedab96da75e8212e8fFilterV2FilterVariant1DeploymentEnvironment.Preview,
                "production" => AutoSDKSharedab96da75e8212e8fFilterV2FilterVariant1DeploymentEnvironment.Production,
                _ => null,
            };
        }
    }
}