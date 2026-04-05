
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant9UiControl
    {
        /// <summary>
        /// 
        /// </summary>
        MultiVercelRegion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant9UiControlExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant9UiControl value)
        {
            return value switch
            {
                GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant9UiControl.MultiVercelRegion => "multi-vercel-region",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant9UiControl? ToEnum(string value)
        {
            return value switch
            {
                "multi-vercel-region" => GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant9UiControl.MultiVercelRegion,
                _ => null,
            };
        }
    }
}