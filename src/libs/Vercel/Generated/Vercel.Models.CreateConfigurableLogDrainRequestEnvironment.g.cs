
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateConfigurableLogDrainRequestEnvironment
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
    public static class CreateConfigurableLogDrainRequestEnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateConfigurableLogDrainRequestEnvironment value)
        {
            return value switch
            {
                CreateConfigurableLogDrainRequestEnvironment.Preview => "preview",
                CreateConfigurableLogDrainRequestEnvironment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateConfigurableLogDrainRequestEnvironment? ToEnum(string value)
        {
            return value switch
            {
                "preview" => CreateConfigurableLogDrainRequestEnvironment.Preview,
                "production" => CreateConfigurableLogDrainRequestEnvironment.Production,
                _ => null,
            };
        }
    }
}