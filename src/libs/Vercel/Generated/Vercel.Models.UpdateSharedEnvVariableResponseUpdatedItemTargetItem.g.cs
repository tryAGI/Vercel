
#nullable enable

namespace Vercel
{
    /// <summary>
    /// environments this env variable targets<br/>
    /// Example: production
    /// </summary>
    public enum UpdateSharedEnvVariableResponseUpdatedItemTargetItem
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
    public static class UpdateSharedEnvVariableResponseUpdatedItemTargetItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateSharedEnvVariableResponseUpdatedItemTargetItem value)
        {
            return value switch
            {
                UpdateSharedEnvVariableResponseUpdatedItemTargetItem.Development => "development",
                UpdateSharedEnvVariableResponseUpdatedItemTargetItem.Preview => "preview",
                UpdateSharedEnvVariableResponseUpdatedItemTargetItem.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateSharedEnvVariableResponseUpdatedItemTargetItem? ToEnum(string value)
        {
            return value switch
            {
                "development" => UpdateSharedEnvVariableResponseUpdatedItemTargetItem.Development,
                "preview" => UpdateSharedEnvVariableResponseUpdatedItemTargetItem.Preview,
                "production" => UpdateSharedEnvVariableResponseUpdatedItemTargetItem.Production,
                _ => null,
            };
        }
    }
}