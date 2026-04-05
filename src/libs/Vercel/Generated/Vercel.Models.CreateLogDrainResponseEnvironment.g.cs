
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The environment of log drain<br/>
    /// Example: [production]
    /// </summary>
    public enum CreateLogDrainResponseEnvironment
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
    public static class CreateLogDrainResponseEnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateLogDrainResponseEnvironment value)
        {
            return value switch
            {
                CreateLogDrainResponseEnvironment.Preview => "preview",
                CreateLogDrainResponseEnvironment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateLogDrainResponseEnvironment? ToEnum(string value)
        {
            return value switch
            {
                "preview" => CreateLogDrainResponseEnvironment.Preview,
                "production" => CreateLogDrainResponseEnvironment.Production,
                _ => null,
            };
        }
    }
}