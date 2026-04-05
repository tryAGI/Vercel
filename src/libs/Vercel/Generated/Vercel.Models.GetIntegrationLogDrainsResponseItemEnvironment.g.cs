
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The environment of log drain<br/>
    /// Example: [production]
    /// </summary>
    public enum GetIntegrationLogDrainsResponseItemEnvironment
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
    public static class GetIntegrationLogDrainsResponseItemEnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetIntegrationLogDrainsResponseItemEnvironment value)
        {
            return value switch
            {
                GetIntegrationLogDrainsResponseItemEnvironment.Preview => "preview",
                GetIntegrationLogDrainsResponseItemEnvironment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetIntegrationLogDrainsResponseItemEnvironment? ToEnum(string value)
        {
            return value switch
            {
                "preview" => GetIntegrationLogDrainsResponseItemEnvironment.Preview,
                "production" => GetIntegrationLogDrainsResponseItemEnvironment.Production,
                _ => null,
            };
        }
    }
}