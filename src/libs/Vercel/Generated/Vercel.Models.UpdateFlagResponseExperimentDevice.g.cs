
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFlagResponseExperimentDevice
    {
        /// <summary>
        /// 
        /// </summary>
        Android,
        /// <summary>
        /// 
        /// </summary>
        Desktop,
        /// <summary>
        /// 
        /// </summary>
        Ios,
        /// <summary>
        /// 
        /// </summary>
        Mweb,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateFlagResponseExperimentDeviceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFlagResponseExperimentDevice value)
        {
            return value switch
            {
                UpdateFlagResponseExperimentDevice.Android => "android",
                UpdateFlagResponseExperimentDevice.Desktop => "desktop",
                UpdateFlagResponseExperimentDevice.Ios => "ios",
                UpdateFlagResponseExperimentDevice.Mweb => "mweb",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFlagResponseExperimentDevice? ToEnum(string value)
        {
            return value switch
            {
                "android" => UpdateFlagResponseExperimentDevice.Android,
                "desktop" => UpdateFlagResponseExperimentDevice.Desktop,
                "ios" => UpdateFlagResponseExperimentDevice.Ios,
                "mweb" => UpdateFlagResponseExperimentDevice.Mweb,
                _ => null,
            };
        }
    }
}