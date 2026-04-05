
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDrainResponseVariant1Status
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
    public static class GetDrainResponseVariant1StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDrainResponseVariant1Status value)
        {
            return value switch
            {
                GetDrainResponseVariant1Status.Disabled => "disabled",
                GetDrainResponseVariant1Status.Enabled => "enabled",
                GetDrainResponseVariant1Status.Errored => "errored",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDrainResponseVariant1Status? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => GetDrainResponseVariant1Status.Disabled,
                "enabled" => GetDrainResponseVariant1Status.Enabled,
                "errored" => GetDrainResponseVariant1Status.Errored,
                _ => null,
            };
        }
    }
}