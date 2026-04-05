
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Excludes redirect project domains when \"false\". Includes redirect project domains when \"true\" (default).<br/>
    /// Default Value: true
    /// </summary>
    public enum GetProjectDomainsRedirects
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
    public static class GetProjectDomainsRedirectsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectDomainsRedirects value)
        {
            return value switch
            {
                GetProjectDomainsRedirects.False => "false",
                GetProjectDomainsRedirects.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectDomainsRedirects? ToEnum(string value)
        {
            return value switch
            {
                "false" => GetProjectDomainsRedirects.False,
                "true" => GetProjectDomainsRedirects.True,
                _ => null,
            };
        }
    }
}