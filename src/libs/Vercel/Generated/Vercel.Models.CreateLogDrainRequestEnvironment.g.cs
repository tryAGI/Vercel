
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateLogDrainRequestEnvironment
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
    public static class CreateLogDrainRequestEnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateLogDrainRequestEnvironment value)
        {
            return value switch
            {
                CreateLogDrainRequestEnvironment.Preview => "preview",
                CreateLogDrainRequestEnvironment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateLogDrainRequestEnvironment? ToEnum(string value)
        {
            return value switch
            {
                "preview" => CreateLogDrainRequestEnvironment.Preview,
                "production" => CreateLogDrainRequestEnvironment.Production,
                _ => null,
            };
        }
    }
}