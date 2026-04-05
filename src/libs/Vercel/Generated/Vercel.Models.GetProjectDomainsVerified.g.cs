
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Filters domains based on their verification status.
    /// </summary>
    public enum GetProjectDomainsVerified
    {
        /// <summary>
        /// 
        /// </summary>
        False,
        /// <summary>
        /// 
        /// </summary>
        True,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectDomainsVerifiedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectDomainsVerified value)
        {
            return value switch
            {
                GetProjectDomainsVerified.False => "false",
                GetProjectDomainsVerified.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectDomainsVerified? ToEnum(string value)
        {
            return value switch
            {
                "false" => GetProjectDomainsVerified.False,
                "true" => GetProjectDomainsVerified.True,
                _ => null,
            };
        }
    }
}