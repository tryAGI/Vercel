
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Whether the log drain was created by an integration or by a user<br/>
    /// Example: integration
    /// </summary>
    public enum AutoSDKShared2208dea57c17c8daCreatedFrom
    {
        /// <summary>
        ///
        /// </summary>
        Integration,
        /// <summary>
        ///
        /// </summary>
        SelfServed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared2208dea57c17c8daCreatedFromExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared2208dea57c17c8daCreatedFrom value)
        {
            return value switch
            {
                AutoSDKShared2208dea57c17c8daCreatedFrom.Integration => "integration",
                AutoSDKShared2208dea57c17c8daCreatedFrom.SelfServed => "self-served",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared2208dea57c17c8daCreatedFrom? ToEnum(string value)
        {
            return value switch
            {
                "integration" => AutoSDKShared2208dea57c17c8daCreatedFrom.Integration,
                "self-served" => AutoSDKShared2208dea57c17c8daCreatedFrom.SelfServed,
                _ => null,
            };
        }
    }
}