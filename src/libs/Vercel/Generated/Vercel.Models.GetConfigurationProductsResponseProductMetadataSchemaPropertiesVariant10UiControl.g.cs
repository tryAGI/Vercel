
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant10UiControl
    {
        /// <summary>
        ///
        /// </summary>
        VercelCountry,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant10UiControlExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant10UiControl value)
        {
            return value switch
            {
                GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant10UiControl.VercelCountry => "vercel-country",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant10UiControl? ToEnum(string value)
        {
            return value switch
            {
                "vercel-country" => GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant10UiControl.VercelCountry,
                _ => null,
            };
        }
    }
}