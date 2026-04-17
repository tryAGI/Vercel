
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectResponseTrustedSourcesProjectsCustomAllowItemFromVariant1Preset
    {
        /// <summary>
        /// 
        /// </summary>
        AllCustom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectResponseTrustedSourcesProjectsCustomAllowItemFromVariant1PresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseTrustedSourcesProjectsCustomAllowItemFromVariant1Preset value)
        {
            return value switch
            {
                CreateProjectResponseTrustedSourcesProjectsCustomAllowItemFromVariant1Preset.AllCustom => "all-custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseTrustedSourcesProjectsCustomAllowItemFromVariant1Preset? ToEnum(string value)
        {
            return value switch
            {
                "all-custom" => CreateProjectResponseTrustedSourcesProjectsCustomAllowItemFromVariant1Preset.AllCustom,
                _ => null,
            };
        }
    }
}