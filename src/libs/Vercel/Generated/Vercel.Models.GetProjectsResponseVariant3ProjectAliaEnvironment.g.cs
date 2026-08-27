
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectAliaEnvironment
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
    public static class GetProjectsResponseVariant3ProjectAliaEnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectAliaEnvironment value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectAliaEnvironment.Preview => "preview",
                GetProjectsResponseVariant3ProjectAliaEnvironment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectAliaEnvironment? ToEnum(string value)
        {
            return value switch
            {
                "preview" => GetProjectsResponseVariant3ProjectAliaEnvironment.Preview,
                "production" => GetProjectsResponseVariant3ProjectAliaEnvironment.Production,
                _ => null,
            };
        }
    }
}