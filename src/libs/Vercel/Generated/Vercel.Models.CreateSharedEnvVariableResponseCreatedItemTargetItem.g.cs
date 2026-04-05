
#nullable enable

namespace Vercel
{
    /// <summary>
    /// environments this env variable targets<br/>
    /// Example: production
    /// </summary>
    public enum CreateSharedEnvVariableResponseCreatedItemTargetItem
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
    public static class CreateSharedEnvVariableResponseCreatedItemTargetItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSharedEnvVariableResponseCreatedItemTargetItem value)
        {
            return value switch
            {
                CreateSharedEnvVariableResponseCreatedItemTargetItem.Development => "development",
                CreateSharedEnvVariableResponseCreatedItemTargetItem.Preview => "preview",
                CreateSharedEnvVariableResponseCreatedItemTargetItem.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSharedEnvVariableResponseCreatedItemTargetItem? ToEnum(string value)
        {
            return value switch
            {
                "development" => CreateSharedEnvVariableResponseCreatedItemTargetItem.Development,
                "preview" => CreateSharedEnvVariableResponseCreatedItemTargetItem.Preview,
                "production" => CreateSharedEnvVariableResponseCreatedItemTargetItem.Production,
                _ => null,
            };
        }
    }
}