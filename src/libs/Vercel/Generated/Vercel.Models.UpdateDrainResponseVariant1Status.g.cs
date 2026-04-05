
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateDrainResponseVariant1Status
    {
        /// <summary>
        /// 
        /// </summary>
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        Enabled,
        /// <summary>
        /// 
        /// </summary>
        Errored,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateDrainResponseVariant1StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDrainResponseVariant1Status value)
        {
            return value switch
            {
                UpdateDrainResponseVariant1Status.Disabled => "disabled",
                UpdateDrainResponseVariant1Status.Enabled => "enabled",
                UpdateDrainResponseVariant1Status.Errored => "errored",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDrainResponseVariant1Status? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => UpdateDrainResponseVariant1Status.Disabled,
                "enabled" => UpdateDrainResponseVariant1Status.Enabled,
                "errored" => UpdateDrainResponseVariant1Status.Errored,
                _ => null,
            };
        }
    }
}