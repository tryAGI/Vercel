
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Filters on the target of the domain. Can be either "production", "preview"
    /// </summary>
    public enum GetProjectDomainsTarget
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
    public static class GetProjectDomainsTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectDomainsTarget value)
        {
            return value switch
            {
                GetProjectDomainsTarget.Preview => "preview",
                GetProjectDomainsTarget.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectDomainsTarget? ToEnum(string value)
        {
            return value switch
            {
                "preview" => GetProjectDomainsTarget.Preview,
                "production" => GetProjectDomainsTarget.Production,
                _ => null,
            };
        }
    }
}