
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreatedByEnvironment
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
    public static class CreatedByEnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatedByEnvironment value)
        {
            return value switch
            {
                CreatedByEnvironment.Development => "development",
                CreatedByEnvironment.Preview => "preview",
                CreatedByEnvironment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatedByEnvironment? ToEnum(string value)
        {
            return value switch
            {
                "development" => CreatedByEnvironment.Development,
                "preview" => CreatedByEnvironment.Preview,
                "production" => CreatedByEnvironment.Production,
                _ => null,
            };
        }
    }
}