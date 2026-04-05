
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateMicrofrontendsResponseEnvItemTarget
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
    public static class UpdateMicrofrontendsResponseEnvItemTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseEnvItemTarget value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseEnvItemTarget.Development => "development",
                UpdateMicrofrontendsResponseEnvItemTarget.Preview => "preview",
                UpdateMicrofrontendsResponseEnvItemTarget.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseEnvItemTarget? ToEnum(string value)
        {
            return value switch
            {
                "development" => UpdateMicrofrontendsResponseEnvItemTarget.Development,
                "preview" => UpdateMicrofrontendsResponseEnvItemTarget.Preview,
                "production" => UpdateMicrofrontendsResponseEnvItemTarget.Production,
                _ => null,
            };
        }
    }
}