
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectResponseTrustedSourcesProjectsCustomAllowItemFromVariant1Preset
    {
        /// <summary>
        /// 
        /// </summary>
        AllCustom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectResponseTrustedSourcesProjectsCustomAllowItemFromVariant1PresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseTrustedSourcesProjectsCustomAllowItemFromVariant1Preset value)
        {
            return value switch
            {
                GetProjectResponseTrustedSourcesProjectsCustomAllowItemFromVariant1Preset.AllCustom => "all-custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseTrustedSourcesProjectsCustomAllowItemFromVariant1Preset? ToEnum(string value)
        {
            return value switch
            {
                "all-custom" => GetProjectResponseTrustedSourcesProjectsCustomAllowItemFromVariant1Preset.AllCustom,
                _ => null,
            };
        }
    }
}