
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectTrustedSourcesProjectsCustomAllowItemToVariant2Preset
    {
        /// <summary>
        /// 
        /// </summary>
        AllCustom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant3ProjectTrustedSourcesProjectsCustomAllowItemToVariant2PresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectTrustedSourcesProjectsCustomAllowItemToVariant2Preset value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectTrustedSourcesProjectsCustomAllowItemToVariant2Preset.AllCustom => "all-custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectTrustedSourcesProjectsCustomAllowItemToVariant2Preset? ToEnum(string value)
        {
            return value switch
            {
                "all-custom" => GetProjectsResponseVariant3ProjectTrustedSourcesProjectsCustomAllowItemToVariant2Preset.AllCustom,
                _ => null,
            };
        }
    }
}