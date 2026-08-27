
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdatedByEnvironment
    {
        /// <summary>
        ///
        /// </summary>
        Development,
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
    public static class UpdatedByEnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdatedByEnvironment value)
        {
            return value switch
            {
                UpdatedByEnvironment.Development => "development",
                UpdatedByEnvironment.Preview => "preview",
                UpdatedByEnvironment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdatedByEnvironment? ToEnum(string value)
        {
            return value switch
            {
                "development" => UpdatedByEnvironment.Development,
                "preview" => UpdatedByEnvironment.Preview,
                "production" => UpdatedByEnvironment.Production,
                _ => null,
            };
        }
    }
}