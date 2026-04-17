
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant1ItemTrustedSourcesProjectsCustomAllowItemToVariant1Preset
    {
        /// <summary>
        /// 
        /// </summary>
        AllCustom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant1ItemTrustedSourcesProjectsCustomAllowItemToVariant1PresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemTrustedSourcesProjectsCustomAllowItemToVariant1Preset value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemTrustedSourcesProjectsCustomAllowItemToVariant1Preset.AllCustom => "all-custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemTrustedSourcesProjectsCustomAllowItemToVariant1Preset? ToEnum(string value)
        {
            return value switch
            {
                "all-custom" => GetProjectsResponseVariant1ItemTrustedSourcesProjectsCustomAllowItemToVariant1Preset.AllCustom,
                _ => null,
            };
        }
    }
}