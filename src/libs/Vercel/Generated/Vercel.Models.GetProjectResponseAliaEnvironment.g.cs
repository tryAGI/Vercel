
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectResponseAliaEnvironment
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
    public static class GetProjectResponseAliaEnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseAliaEnvironment value)
        {
            return value switch
            {
                GetProjectResponseAliaEnvironment.Preview => "preview",
                GetProjectResponseAliaEnvironment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseAliaEnvironment? ToEnum(string value)
        {
            return value switch
            {
                "preview" => GetProjectResponseAliaEnvironment.Preview,
                "production" => GetProjectResponseAliaEnvironment.Production,
                _ => null,
            };
        }
    }
}