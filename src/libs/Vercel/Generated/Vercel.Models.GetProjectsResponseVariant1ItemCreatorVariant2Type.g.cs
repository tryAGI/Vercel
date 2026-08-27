
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectsResponseVariant1ItemCreatorVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        App,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant1ItemCreatorVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemCreatorVariant2Type value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemCreatorVariant2Type.App => "app",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemCreatorVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "app" => GetProjectsResponseVariant1ItemCreatorVariant2Type.App,
                _ => null,
            };
        }
    }
}