
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant8UiControl
    {
        /// <summary>
        /// 
        /// </summary>
        VercelRegion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant8UiControlExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant8UiControl value)
        {
            return value switch
            {
                GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant8UiControl.VercelRegion => "vercel-region",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant8UiControl? ToEnum(string value)
        {
            return value switch
            {
                "vercel-region" => GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant8UiControl.VercelRegion,
                _ => null,
            };
        }
    }
}