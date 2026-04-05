
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateSharedEnvVariableResponseFailedItemErrorTarget
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
    public static class UpdateSharedEnvVariableResponseFailedItemErrorTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateSharedEnvVariableResponseFailedItemErrorTarget value)
        {
            return value switch
            {
                UpdateSharedEnvVariableResponseFailedItemErrorTarget.Development => "development",
                UpdateSharedEnvVariableResponseFailedItemErrorTarget.Preview => "preview",
                UpdateSharedEnvVariableResponseFailedItemErrorTarget.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateSharedEnvVariableResponseFailedItemErrorTarget? ToEnum(string value)
        {
            return value switch
            {
                "development" => UpdateSharedEnvVariableResponseFailedItemErrorTarget.Development,
                "preview" => UpdateSharedEnvVariableResponseFailedItemErrorTarget.Preview,
                "production" => UpdateSharedEnvVariableResponseFailedItemErrorTarget.Production,
                _ => null,
            };
        }
    }
}