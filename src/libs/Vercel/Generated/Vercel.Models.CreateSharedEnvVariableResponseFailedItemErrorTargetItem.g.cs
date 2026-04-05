
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSharedEnvVariableResponseFailedItemErrorTargetItem
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
    public static class CreateSharedEnvVariableResponseFailedItemErrorTargetItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSharedEnvVariableResponseFailedItemErrorTargetItem value)
        {
            return value switch
            {
                CreateSharedEnvVariableResponseFailedItemErrorTargetItem.Development => "development",
                CreateSharedEnvVariableResponseFailedItemErrorTargetItem.Preview => "preview",
                CreateSharedEnvVariableResponseFailedItemErrorTargetItem.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSharedEnvVariableResponseFailedItemErrorTargetItem? ToEnum(string value)
        {
            return value switch
            {
                "development" => CreateSharedEnvVariableResponseFailedItemErrorTargetItem.Development,
                "preview" => CreateSharedEnvVariableResponseFailedItemErrorTargetItem.Preview,
                "production" => CreateSharedEnvVariableResponseFailedItemErrorTargetItem.Production,
                _ => null,
            };
        }
    }
}