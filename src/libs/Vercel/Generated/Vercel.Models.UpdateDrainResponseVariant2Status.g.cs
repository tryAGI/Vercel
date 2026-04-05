
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateDrainResponseVariant2Status
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
    public static class UpdateDrainResponseVariant2StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDrainResponseVariant2Status value)
        {
            return value switch
            {
                UpdateDrainResponseVariant2Status.Disabled => "disabled",
                UpdateDrainResponseVariant2Status.Enabled => "enabled",
                UpdateDrainResponseVariant2Status.Errored => "errored",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDrainResponseVariant2Status? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => UpdateDrainResponseVariant2Status.Disabled,
                "enabled" => UpdateDrainResponseVariant2Status.Enabled,
                "errored" => UpdateDrainResponseVariant2Status.Errored,
                _ => null,
            };
        }
    }
}