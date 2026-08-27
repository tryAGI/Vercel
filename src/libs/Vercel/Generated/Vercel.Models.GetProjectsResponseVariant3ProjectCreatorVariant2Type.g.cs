
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectCreatorVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        App,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant3ProjectCreatorVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectCreatorVariant2Type value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectCreatorVariant2Type.App => "app",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectCreatorVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "app" => GetProjectsResponseVariant3ProjectCreatorVariant2Type.App,
                _ => null,
            };
        }
    }
}