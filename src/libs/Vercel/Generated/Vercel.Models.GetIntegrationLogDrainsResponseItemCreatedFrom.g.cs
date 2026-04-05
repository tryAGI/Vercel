
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Whether the log drain was created by an integration or by a user<br/>
    /// Example: integration
    /// </summary>
    public enum GetIntegrationLogDrainsResponseItemCreatedFrom
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
    public static class GetIntegrationLogDrainsResponseItemCreatedFromExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetIntegrationLogDrainsResponseItemCreatedFrom value)
        {
            return value switch
            {
                GetIntegrationLogDrainsResponseItemCreatedFrom.Integration => "integration",
                GetIntegrationLogDrainsResponseItemCreatedFrom.SelfServed => "self-served",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetIntegrationLogDrainsResponseItemCreatedFrom? ToEnum(string value)
        {
            return value switch
            {
                "integration" => GetIntegrationLogDrainsResponseItemCreatedFrom.Integration,
                "self-served" => GetIntegrationLogDrainsResponseItemCreatedFrom.SelfServed,
                _ => null,
            };
        }
    }
}