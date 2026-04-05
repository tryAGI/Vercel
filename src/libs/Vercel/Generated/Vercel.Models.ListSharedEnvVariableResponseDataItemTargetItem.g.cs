
#nullable enable

namespace Vercel
{
    /// <summary>
    /// environments this env variable targets<br/>
    /// Example: production
    /// </summary>
    public enum ListSharedEnvVariableResponseDataItemTargetItem
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
    public static class ListSharedEnvVariableResponseDataItemTargetItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListSharedEnvVariableResponseDataItemTargetItem value)
        {
            return value switch
            {
                ListSharedEnvVariableResponseDataItemTargetItem.Development => "development",
                ListSharedEnvVariableResponseDataItemTargetItem.Preview => "preview",
                ListSharedEnvVariableResponseDataItemTargetItem.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListSharedEnvVariableResponseDataItemTargetItem? ToEnum(string value)
        {
            return value switch
            {
                "development" => ListSharedEnvVariableResponseDataItemTargetItem.Development,
                "preview" => ListSharedEnvVariableResponseDataItemTargetItem.Preview,
                "production" => ListSharedEnvVariableResponseDataItemTargetItem.Production,
                _ => null,
            };
        }
    }
}