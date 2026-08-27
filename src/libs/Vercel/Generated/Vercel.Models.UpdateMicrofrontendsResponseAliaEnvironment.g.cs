
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateMicrofrontendsResponseAliaEnvironment
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
    public static class UpdateMicrofrontendsResponseAliaEnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseAliaEnvironment value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseAliaEnvironment.Preview => "preview",
                UpdateMicrofrontendsResponseAliaEnvironment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseAliaEnvironment? ToEnum(string value)
        {
            return value switch
            {
                "preview" => UpdateMicrofrontendsResponseAliaEnvironment.Preview,
                "production" => UpdateMicrofrontendsResponseAliaEnvironment.Production,
                _ => null,
            };
        }
    }
}