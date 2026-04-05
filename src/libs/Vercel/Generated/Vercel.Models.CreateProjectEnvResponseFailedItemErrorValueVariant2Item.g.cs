
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectEnvResponseFailedItemErrorValueVariant2Item
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
    public static class CreateProjectEnvResponseFailedItemErrorValueVariant2ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectEnvResponseFailedItemErrorValueVariant2Item value)
        {
            return value switch
            {
                CreateProjectEnvResponseFailedItemErrorValueVariant2Item.Development => "development",
                CreateProjectEnvResponseFailedItemErrorValueVariant2Item.Preview => "preview",
                CreateProjectEnvResponseFailedItemErrorValueVariant2Item.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectEnvResponseFailedItemErrorValueVariant2Item? ToEnum(string value)
        {
            return value switch
            {
                "development" => CreateProjectEnvResponseFailedItemErrorValueVariant2Item.Development,
                "preview" => CreateProjectEnvResponseFailedItemErrorValueVariant2Item.Preview,
                "production" => CreateProjectEnvResponseFailedItemErrorValueVariant2Item.Production,
                _ => null,
            };
        }
    }
}