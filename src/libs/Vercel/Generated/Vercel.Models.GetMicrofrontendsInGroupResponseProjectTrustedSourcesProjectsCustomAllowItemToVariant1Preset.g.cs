
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectTrustedSourcesProjectsCustomAllowItemToVariant1Preset
    {
        /// <summary>
        /// 
        /// </summary>
        AllCustom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetMicrofrontendsInGroupResponseProjectTrustedSourcesProjectsCustomAllowItemToVariant1PresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectTrustedSourcesProjectsCustomAllowItemToVariant1Preset value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectTrustedSourcesProjectsCustomAllowItemToVariant1Preset.AllCustom => "all-custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectTrustedSourcesProjectsCustomAllowItemToVariant1Preset? ToEnum(string value)
        {
            return value switch
            {
                "all-custom" => GetMicrofrontendsInGroupResponseProjectTrustedSourcesProjectsCustomAllowItemToVariant1Preset.AllCustom,
                _ => null,
            };
        }
    }
}