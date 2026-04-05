
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant2UiControl
    {
        /// <summary>
        /// 
        /// </summary>
        Input,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant2UiControlExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant2UiControl value)
        {
            return value switch
            {
                GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant2UiControl.Input => "input",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant2UiControl? ToEnum(string value)
        {
            return value switch
            {
                "input" => GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant2UiControl.Input,
                _ => null,
            };
        }
    }
}