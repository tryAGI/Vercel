
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateProjectResponseAliaEnvironment
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
    public static class CreateProjectResponseAliaEnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseAliaEnvironment value)
        {
            return value switch
            {
                CreateProjectResponseAliaEnvironment.Preview => "preview",
                CreateProjectResponseAliaEnvironment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseAliaEnvironment? ToEnum(string value)
        {
            return value switch
            {
                "preview" => CreateProjectResponseAliaEnvironment.Preview,
                "production" => CreateProjectResponseAliaEnvironment.Production,
                _ => null,
            };
        }
    }
}