
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectResponseTrustedSourcesProjectsCustomAllowItemToVariant1Preset
    {
        /// <summary>
        /// 
        /// </summary>
        AllCustom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectResponseTrustedSourcesProjectsCustomAllowItemToVariant1PresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseTrustedSourcesProjectsCustomAllowItemToVariant1Preset value)
        {
            return value switch
            {
                CreateProjectResponseTrustedSourcesProjectsCustomAllowItemToVariant1Preset.AllCustom => "all-custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseTrustedSourcesProjectsCustomAllowItemToVariant1Preset? ToEnum(string value)
        {
            return value switch
            {
                "all-custom" => CreateProjectResponseTrustedSourcesProjectsCustomAllowItemToVariant1Preset.AllCustom,
                _ => null,
            };
        }
    }
}