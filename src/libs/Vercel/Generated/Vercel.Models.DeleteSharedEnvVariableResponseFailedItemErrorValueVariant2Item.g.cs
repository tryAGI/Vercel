
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeleteSharedEnvVariableResponseFailedItemErrorValueVariant2Item
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
    public static class DeleteSharedEnvVariableResponseFailedItemErrorValueVariant2ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteSharedEnvVariableResponseFailedItemErrorValueVariant2Item value)
        {
            return value switch
            {
                DeleteSharedEnvVariableResponseFailedItemErrorValueVariant2Item.Development => "development",
                DeleteSharedEnvVariableResponseFailedItemErrorValueVariant2Item.Preview => "preview",
                DeleteSharedEnvVariableResponseFailedItemErrorValueVariant2Item.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteSharedEnvVariableResponseFailedItemErrorValueVariant2Item? ToEnum(string value)
        {
            return value switch
            {
                "development" => DeleteSharedEnvVariableResponseFailedItemErrorValueVariant2Item.Development,
                "preview" => DeleteSharedEnvVariableResponseFailedItemErrorValueVariant2Item.Preview,
                "production" => DeleteSharedEnvVariableResponseFailedItemErrorValueVariant2Item.Production,
                _ => null,
            };
        }
    }
}