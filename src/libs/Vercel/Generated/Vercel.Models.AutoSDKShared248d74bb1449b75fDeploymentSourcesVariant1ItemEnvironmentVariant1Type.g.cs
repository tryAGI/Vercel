
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared248d74bb1449b75fDeploymentSourcesVariant1ItemEnvironmentVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared248d74bb1449b75fDeploymentSourcesVariant1ItemEnvironmentVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared248d74bb1449b75fDeploymentSourcesVariant1ItemEnvironmentVariant1Type value)
        {
            return value switch
            {
                AutoSDKShared248d74bb1449b75fDeploymentSourcesVariant1ItemEnvironmentVariant1Type.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared248d74bb1449b75fDeploymentSourcesVariant1ItemEnvironmentVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "system" => AutoSDKShared248d74bb1449b75fDeploymentSourcesVariant1ItemEnvironmentVariant1Type.System,
                _ => null,
            };
        }
    }
}