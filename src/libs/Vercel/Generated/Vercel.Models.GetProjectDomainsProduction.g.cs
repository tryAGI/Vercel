
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Filters only production domains when set to `true`.<br/>
    /// Default Value: false
    /// </summary>
    public enum GetProjectDomainsProduction
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
    public static class GetProjectDomainsProductionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectDomainsProduction value)
        {
            return value switch
            {
                GetProjectDomainsProduction.False => "false",
                GetProjectDomainsProduction.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectDomainsProduction? ToEnum(string value)
        {
            return value switch
            {
                "false" => GetProjectDomainsProduction.False,
                "true" => GetProjectDomainsProduction.True,
                _ => null,
            };
        }
    }
}