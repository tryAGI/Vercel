
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeleteSharedEnvVariableResponseFailedItemErrorTargetItem
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
    public static class DeleteSharedEnvVariableResponseFailedItemErrorTargetItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteSharedEnvVariableResponseFailedItemErrorTargetItem value)
        {
            return value switch
            {
                DeleteSharedEnvVariableResponseFailedItemErrorTargetItem.Development => "development",
                DeleteSharedEnvVariableResponseFailedItemErrorTargetItem.Preview => "preview",
                DeleteSharedEnvVariableResponseFailedItemErrorTargetItem.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteSharedEnvVariableResponseFailedItemErrorTargetItem? ToEnum(string value)
        {
            return value switch
            {
                "development" => DeleteSharedEnvVariableResponseFailedItemErrorTargetItem.Development,
                "preview" => DeleteSharedEnvVariableResponseFailedItemErrorTargetItem.Preview,
                "production" => DeleteSharedEnvVariableResponseFailedItemErrorTargetItem.Production,
                _ => null,
            };
        }
    }
}