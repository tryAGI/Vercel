
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSharedEnvVariableResponseFailedItemErrorValueVariant2Item
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
    public static class CreateSharedEnvVariableResponseFailedItemErrorValueVariant2ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSharedEnvVariableResponseFailedItemErrorValueVariant2Item value)
        {
            return value switch
            {
                CreateSharedEnvVariableResponseFailedItemErrorValueVariant2Item.Development => "development",
                CreateSharedEnvVariableResponseFailedItemErrorValueVariant2Item.Preview => "preview",
                CreateSharedEnvVariableResponseFailedItemErrorValueVariant2Item.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSharedEnvVariableResponseFailedItemErrorValueVariant2Item? ToEnum(string value)
        {
            return value switch
            {
                "development" => CreateSharedEnvVariableResponseFailedItemErrorValueVariant2Item.Development,
                "preview" => CreateSharedEnvVariableResponseFailedItemErrorValueVariant2Item.Preview,
                "production" => CreateSharedEnvVariableResponseFailedItemErrorValueVariant2Item.Production,
                _ => null,
            };
        }
    }
}