
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The environment of log drain<br/>
    /// Example: [production]
    /// </summary>
    public enum AutoSDKShared2208dea57c17c8daEnvironment
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
    public static class AutoSDKShared2208dea57c17c8daEnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared2208dea57c17c8daEnvironment value)
        {
            return value switch
            {
                AutoSDKShared2208dea57c17c8daEnvironment.Preview => "preview",
                AutoSDKShared2208dea57c17c8daEnvironment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared2208dea57c17c8daEnvironment? ToEnum(string value)
        {
            return value switch
            {
                "preview" => AutoSDKShared2208dea57c17c8daEnvironment.Preview,
                "production" => AutoSDKShared2208dea57c17c8daEnvironment.Production,
                _ => null,
            };
        }
    }
}