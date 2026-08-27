
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectCreatorVariant1ViaVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        App,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant2ProjectCreatorVariant1ViaVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectCreatorVariant1ViaVariant1Type value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectCreatorVariant1ViaVariant1Type.App => "app",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectCreatorVariant1ViaVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "app" => GetProjectsResponseVariant2ProjectCreatorVariant1ViaVariant1Type.App,
                _ => null,
            };
        }
    }
}