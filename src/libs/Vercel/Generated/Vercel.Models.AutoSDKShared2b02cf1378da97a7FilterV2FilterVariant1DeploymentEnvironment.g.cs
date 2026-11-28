
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared2b02cf1378da97a7FilterV2FilterVariant1DeploymentEnvironment
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
    public static class AutoSDKShared2b02cf1378da97a7FilterV2FilterVariant1DeploymentEnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared2b02cf1378da97a7FilterV2FilterVariant1DeploymentEnvironment value)
        {
            return value switch
            {
                AutoSDKShared2b02cf1378da97a7FilterV2FilterVariant1DeploymentEnvironment.Preview => "preview",
                AutoSDKShared2b02cf1378da97a7FilterV2FilterVariant1DeploymentEnvironment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared2b02cf1378da97a7FilterV2FilterVariant1DeploymentEnvironment? ToEnum(string value)
        {
            return value switch
            {
                "preview" => AutoSDKShared2b02cf1378da97a7FilterV2FilterVariant1DeploymentEnvironment.Preview,
                "production" => AutoSDKShared2b02cf1378da97a7FilterV2FilterVariant1DeploymentEnvironment.Production,
                _ => null,
            };
        }
    }
}