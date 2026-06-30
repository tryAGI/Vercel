
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponseAliaEnvironment
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
    public static class UpdateProjectResponseAliaEnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseAliaEnvironment value)
        {
            return value switch
            {
                UpdateProjectResponseAliaEnvironment.Preview => "preview",
                UpdateProjectResponseAliaEnvironment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseAliaEnvironment? ToEnum(string value)
        {
            return value switch
            {
                "preview" => UpdateProjectResponseAliaEnvironment.Preview,
                "production" => UpdateProjectResponseAliaEnvironment.Production,
                _ => null,
            };
        }
    }
}