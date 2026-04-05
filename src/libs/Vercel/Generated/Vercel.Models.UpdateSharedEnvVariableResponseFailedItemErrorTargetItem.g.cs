
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateSharedEnvVariableResponseFailedItemErrorTargetItem
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
    public static class UpdateSharedEnvVariableResponseFailedItemErrorTargetItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateSharedEnvVariableResponseFailedItemErrorTargetItem value)
        {
            return value switch
            {
                UpdateSharedEnvVariableResponseFailedItemErrorTargetItem.Development => "development",
                UpdateSharedEnvVariableResponseFailedItemErrorTargetItem.Preview => "preview",
                UpdateSharedEnvVariableResponseFailedItemErrorTargetItem.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateSharedEnvVariableResponseFailedItemErrorTargetItem? ToEnum(string value)
        {
            return value switch
            {
                "development" => UpdateSharedEnvVariableResponseFailedItemErrorTargetItem.Development,
                "preview" => UpdateSharedEnvVariableResponseFailedItemErrorTargetItem.Preview,
                "production" => UpdateSharedEnvVariableResponseFailedItemErrorTargetItem.Production,
                _ => null,
            };
        }
    }
}