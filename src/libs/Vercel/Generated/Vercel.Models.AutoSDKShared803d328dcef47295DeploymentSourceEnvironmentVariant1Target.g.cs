
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared803d328dcef47295DeploymentSourceEnvironmentVariant1Target
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
    public static class AutoSDKShared803d328dcef47295DeploymentSourceEnvironmentVariant1TargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared803d328dcef47295DeploymentSourceEnvironmentVariant1Target value)
        {
            return value switch
            {
                AutoSDKShared803d328dcef47295DeploymentSourceEnvironmentVariant1Target.Preview => "preview",
                AutoSDKShared803d328dcef47295DeploymentSourceEnvironmentVariant1Target.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared803d328dcef47295DeploymentSourceEnvironmentVariant1Target? ToEnum(string value)
        {
            return value switch
            {
                "preview" => AutoSDKShared803d328dcef47295DeploymentSourceEnvironmentVariant1Target.Preview,
                "production" => AutoSDKShared803d328dcef47295DeploymentSourceEnvironmentVariant1Target.Production,
                _ => null,
            };
        }
    }
}