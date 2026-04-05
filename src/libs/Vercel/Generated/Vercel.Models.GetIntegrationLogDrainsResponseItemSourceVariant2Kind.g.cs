
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetIntegrationLogDrainsResponseItemSourceVariant2Kind
    {
        /// <summary>
        /// 
        /// </summary>
        Integration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetIntegrationLogDrainsResponseItemSourceVariant2KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetIntegrationLogDrainsResponseItemSourceVariant2Kind value)
        {
            return value switch
            {
                GetIntegrationLogDrainsResponseItemSourceVariant2Kind.Integration => "integration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetIntegrationLogDrainsResponseItemSourceVariant2Kind? ToEnum(string value)
        {
            return value switch
            {
                "integration" => GetIntegrationLogDrainsResponseItemSourceVariant2Kind.Integration,
                _ => null,
            };
        }
    }
}