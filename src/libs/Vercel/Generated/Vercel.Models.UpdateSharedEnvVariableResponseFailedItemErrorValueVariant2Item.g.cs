
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateSharedEnvVariableResponseFailedItemErrorValueVariant2Item
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
    public static class UpdateSharedEnvVariableResponseFailedItemErrorValueVariant2ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateSharedEnvVariableResponseFailedItemErrorValueVariant2Item value)
        {
            return value switch
            {
                UpdateSharedEnvVariableResponseFailedItemErrorValueVariant2Item.Development => "development",
                UpdateSharedEnvVariableResponseFailedItemErrorValueVariant2Item.Preview => "preview",
                UpdateSharedEnvVariableResponseFailedItemErrorValueVariant2Item.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateSharedEnvVariableResponseFailedItemErrorValueVariant2Item? ToEnum(string value)
        {
            return value switch
            {
                "development" => UpdateSharedEnvVariableResponseFailedItemErrorValueVariant2Item.Development,
                "preview" => UpdateSharedEnvVariableResponseFailedItemErrorValueVariant2Item.Preview,
                "production" => UpdateSharedEnvVariableResponseFailedItemErrorValueVariant2Item.Production,
                _ => null,
            };
        }
    }
}