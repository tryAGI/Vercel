
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSharedEnvVariableResponseFailedItemErrorTarget
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
    public static class CreateSharedEnvVariableResponseFailedItemErrorTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSharedEnvVariableResponseFailedItemErrorTarget value)
        {
            return value switch
            {
                CreateSharedEnvVariableResponseFailedItemErrorTarget.Development => "development",
                CreateSharedEnvVariableResponseFailedItemErrorTarget.Preview => "preview",
                CreateSharedEnvVariableResponseFailedItemErrorTarget.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSharedEnvVariableResponseFailedItemErrorTarget? ToEnum(string value)
        {
            return value switch
            {
                "development" => CreateSharedEnvVariableResponseFailedItemErrorTarget.Development,
                "preview" => CreateSharedEnvVariableResponseFailedItemErrorTarget.Preview,
                "production" => CreateSharedEnvVariableResponseFailedItemErrorTarget.Production,
                _ => null,
            };
        }
    }
}