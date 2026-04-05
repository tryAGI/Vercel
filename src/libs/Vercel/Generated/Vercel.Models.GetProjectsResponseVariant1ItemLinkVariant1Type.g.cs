
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant1ItemLinkVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Github,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant1ItemLinkVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemLinkVariant1Type value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemLinkVariant1Type.Github => "github",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemLinkVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "github" => GetProjectsResponseVariant1ItemLinkVariant1Type.Github,
                _ => null,
            };
        }
    }
}