
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateSharedEnvVariableRequestUpdatesTargetItem
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
    public static class UpdateSharedEnvVariableRequestUpdatesTargetItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateSharedEnvVariableRequestUpdatesTargetItem value)
        {
            return value switch
            {
                UpdateSharedEnvVariableRequestUpdatesTargetItem.Development => "development",
                UpdateSharedEnvVariableRequestUpdatesTargetItem.Preview => "preview",
                UpdateSharedEnvVariableRequestUpdatesTargetItem.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateSharedEnvVariableRequestUpdatesTargetItem? ToEnum(string value)
        {
            return value switch
            {
                "development" => UpdateSharedEnvVariableRequestUpdatesTargetItem.Development,
                "preview" => UpdateSharedEnvVariableRequestUpdatesTargetItem.Preview,
                "production" => UpdateSharedEnvVariableRequestUpdatesTargetItem.Production,
                _ => null,
            };
        }
    }
}