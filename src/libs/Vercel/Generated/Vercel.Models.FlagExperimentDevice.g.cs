
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum FlagExperimentDevice
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
    public static class FlagExperimentDeviceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FlagExperimentDevice value)
        {
            return value switch
            {
                FlagExperimentDevice.Android => "android",
                FlagExperimentDevice.Desktop => "desktop",
                FlagExperimentDevice.Ios => "ios",
                FlagExperimentDevice.Mweb => "mweb",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FlagExperimentDevice? ToEnum(string value)
        {
            return value switch
            {
                "android" => FlagExperimentDevice.Android,
                "desktop" => FlagExperimentDevice.Desktop,
                "ios" => FlagExperimentDevice.Ios,
                "mweb" => FlagExperimentDevice.Mweb,
                _ => null,
            };
        }
    }
}