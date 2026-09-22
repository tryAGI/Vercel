
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared248d74bb1449b75fDeploymentSourcesVariant1ItemEnvironmentVariant1Target
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
    public static class AutoSDKShared248d74bb1449b75fDeploymentSourcesVariant1ItemEnvironmentVariant1TargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared248d74bb1449b75fDeploymentSourcesVariant1ItemEnvironmentVariant1Target value)
        {
            return value switch
            {
                AutoSDKShared248d74bb1449b75fDeploymentSourcesVariant1ItemEnvironmentVariant1Target.Preview => "preview",
                AutoSDKShared248d74bb1449b75fDeploymentSourcesVariant1ItemEnvironmentVariant1Target.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared248d74bb1449b75fDeploymentSourcesVariant1ItemEnvironmentVariant1Target? ToEnum(string value)
        {
            return value switch
            {
                "preview" => AutoSDKShared248d74bb1449b75fDeploymentSourcesVariant1ItemEnvironmentVariant1Target.Preview,
                "production" => AutoSDKShared248d74bb1449b75fDeploymentSourcesVariant1ItemEnvironmentVariant1Target.Production,
                _ => null,
            };
        }
    }
}