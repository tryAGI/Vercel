
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetIntegrationLogDrainsResponseItemSourceVariant1Kind
    {
        /// <summary>
        /// 
        /// </summary>
        SelfServed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetIntegrationLogDrainsResponseItemSourceVariant1KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetIntegrationLogDrainsResponseItemSourceVariant1Kind value)
        {
            return value switch
            {
                GetIntegrationLogDrainsResponseItemSourceVariant1Kind.SelfServed => "self-served",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetIntegrationLogDrainsResponseItemSourceVariant1Kind? ToEnum(string value)
        {
            return value switch
            {
                "self-served" => GetIntegrationLogDrainsResponseItemSourceVariant1Kind.SelfServed,
                _ => null,
            };
        }
    }
}