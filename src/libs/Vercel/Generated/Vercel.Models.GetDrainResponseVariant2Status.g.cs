
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDrainResponseVariant2Status
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
    public static class GetDrainResponseVariant2StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDrainResponseVariant2Status value)
        {
            return value switch
            {
                GetDrainResponseVariant2Status.Disabled => "disabled",
                GetDrainResponseVariant2Status.Enabled => "enabled",
                GetDrainResponseVariant2Status.Errored => "errored",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDrainResponseVariant2Status? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => GetDrainResponseVariant2Status.Disabled,
                "enabled" => GetDrainResponseVariant2Status.Enabled,
                "errored" => GetDrainResponseVariant2Status.Errored,
                _ => null,
            };
        }
    }
}