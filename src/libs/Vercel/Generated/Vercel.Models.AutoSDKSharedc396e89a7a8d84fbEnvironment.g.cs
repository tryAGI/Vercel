
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The environment of log drain<br/>
    /// Example: [production]
    /// </summary>
    public enum AutoSDKSharedc396e89a7a8d84fbEnvironment
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
    public static class AutoSDKSharedc396e89a7a8d84fbEnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc396e89a7a8d84fbEnvironment value)
        {
            return value switch
            {
                AutoSDKSharedc396e89a7a8d84fbEnvironment.Preview => "preview",
                AutoSDKSharedc396e89a7a8d84fbEnvironment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc396e89a7a8d84fbEnvironment? ToEnum(string value)
        {
            return value switch
            {
                "preview" => AutoSDKSharedc396e89a7a8d84fbEnvironment.Preview,
                "production" => AutoSDKSharedc396e89a7a8d84fbEnvironment.Production,
                _ => null,
            };
        }
    }
}