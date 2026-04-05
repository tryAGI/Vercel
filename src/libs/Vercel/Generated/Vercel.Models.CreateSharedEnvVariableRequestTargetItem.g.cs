
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSharedEnvVariableRequestTargetItem
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
    public static class CreateSharedEnvVariableRequestTargetItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSharedEnvVariableRequestTargetItem value)
        {
            return value switch
            {
                CreateSharedEnvVariableRequestTargetItem.Development => "development",
                CreateSharedEnvVariableRequestTargetItem.Preview => "preview",
                CreateSharedEnvVariableRequestTargetItem.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSharedEnvVariableRequestTargetItem? ToEnum(string value)
        {
            return value switch
            {
                "development" => CreateSharedEnvVariableRequestTargetItem.Development,
                "preview" => CreateSharedEnvVariableRequestTargetItem.Preview,
                "production" => CreateSharedEnvVariableRequestTargetItem.Production,
                _ => null,
            };
        }
    }
}