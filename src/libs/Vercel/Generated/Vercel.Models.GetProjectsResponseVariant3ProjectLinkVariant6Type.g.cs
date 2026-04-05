
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectLinkVariant6Type
    {
        /// <summary>
        /// 
        /// </summary>
        Vercel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant3ProjectLinkVariant6TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectLinkVariant6Type value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectLinkVariant6Type.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectLinkVariant6Type? ToEnum(string value)
        {
            return value switch
            {
                "vercel" => GetProjectsResponseVariant3ProjectLinkVariant6Type.Vercel,
                _ => null,
            };
        }
    }
}