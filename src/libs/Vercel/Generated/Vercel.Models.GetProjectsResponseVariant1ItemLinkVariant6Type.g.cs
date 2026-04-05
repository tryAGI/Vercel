
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant1ItemLinkVariant6Type
    {
        /// <summary>
        /// 
        /// </summary>
        Vercel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant1ItemLinkVariant6TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemLinkVariant6Type value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemLinkVariant6Type.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemLinkVariant6Type? ToEnum(string value)
        {
            return value switch
            {
                "vercel" => GetProjectsResponseVariant1ItemLinkVariant6Type.Vercel,
                _ => null,
            };
        }
    }
}