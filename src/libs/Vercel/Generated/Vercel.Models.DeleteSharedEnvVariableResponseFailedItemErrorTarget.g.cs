
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeleteSharedEnvVariableResponseFailedItemErrorTarget
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
    public static class DeleteSharedEnvVariableResponseFailedItemErrorTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteSharedEnvVariableResponseFailedItemErrorTarget value)
        {
            return value switch
            {
                DeleteSharedEnvVariableResponseFailedItemErrorTarget.Development => "development",
                DeleteSharedEnvVariableResponseFailedItemErrorTarget.Preview => "preview",
                DeleteSharedEnvVariableResponseFailedItemErrorTarget.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteSharedEnvVariableResponseFailedItemErrorTarget? ToEnum(string value)
        {
            return value switch
            {
                "development" => DeleteSharedEnvVariableResponseFailedItemErrorTarget.Development,
                "preview" => DeleteSharedEnvVariableResponseFailedItemErrorTarget.Preview,
                "production" => DeleteSharedEnvVariableResponseFailedItemErrorTarget.Production,
                _ => null,
            };
        }
    }
}