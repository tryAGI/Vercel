
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectTrustedSourcesProjectsCustomAllowItemFromVariant1Preset
    {
        /// <summary>
        /// 
        /// </summary>
        AllCustom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant2ProjectTrustedSourcesProjectsCustomAllowItemFromVariant1PresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectTrustedSourcesProjectsCustomAllowItemFromVariant1Preset value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectTrustedSourcesProjectsCustomAllowItemFromVariant1Preset.AllCustom => "all-custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectTrustedSourcesProjectsCustomAllowItemFromVariant1Preset? ToEnum(string value)
        {
            return value switch
            {
                "all-custom" => GetProjectsResponseVariant2ProjectTrustedSourcesProjectsCustomAllowItemFromVariant1Preset.AllCustom,
                _ => null,
            };
        }
    }
}