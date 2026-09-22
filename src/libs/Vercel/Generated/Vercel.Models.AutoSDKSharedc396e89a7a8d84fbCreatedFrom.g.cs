
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Whether the log drain was created by an integration or by a user<br/>
    /// Example: integration
    /// </summary>
    public enum AutoSDKSharedc396e89a7a8d84fbCreatedFrom
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
    public static class AutoSDKSharedc396e89a7a8d84fbCreatedFromExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc396e89a7a8d84fbCreatedFrom value)
        {
            return value switch
            {
                AutoSDKSharedc396e89a7a8d84fbCreatedFrom.Integration => "integration",
                AutoSDKSharedc396e89a7a8d84fbCreatedFrom.SelfServed => "self-served",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc396e89a7a8d84fbCreatedFrom? ToEnum(string value)
        {
            return value switch
            {
                "integration" => AutoSDKSharedc396e89a7a8d84fbCreatedFrom.Integration,
                "self-served" => AutoSDKSharedc396e89a7a8d84fbCreatedFrom.SelfServed,
                _ => null,
            };
        }
    }
}