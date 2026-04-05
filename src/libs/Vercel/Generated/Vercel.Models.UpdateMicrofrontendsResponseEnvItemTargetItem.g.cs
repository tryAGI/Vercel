
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateMicrofrontendsResponseEnvItemTargetItem
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
    public static class UpdateMicrofrontendsResponseEnvItemTargetItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseEnvItemTargetItem value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseEnvItemTargetItem.Development => "development",
                UpdateMicrofrontendsResponseEnvItemTargetItem.Preview => "preview",
                UpdateMicrofrontendsResponseEnvItemTargetItem.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseEnvItemTargetItem? ToEnum(string value)
        {
            return value switch
            {
                "development" => UpdateMicrofrontendsResponseEnvItemTargetItem.Development,
                "preview" => UpdateMicrofrontendsResponseEnvItemTargetItem.Preview,
                "production" => UpdateMicrofrontendsResponseEnvItemTargetItem.Production,
                _ => null,
            };
        }
    }
}