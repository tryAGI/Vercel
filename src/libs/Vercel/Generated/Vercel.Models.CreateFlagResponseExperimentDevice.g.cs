
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateFlagResponseExperimentDevice
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
    public static class CreateFlagResponseExperimentDeviceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateFlagResponseExperimentDevice value)
        {
            return value switch
            {
                CreateFlagResponseExperimentDevice.Android => "android",
                CreateFlagResponseExperimentDevice.Desktop => "desktop",
                CreateFlagResponseExperimentDevice.Ios => "ios",
                CreateFlagResponseExperimentDevice.Mweb => "mweb",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateFlagResponseExperimentDevice? ToEnum(string value)
        {
            return value switch
            {
                "android" => CreateFlagResponseExperimentDevice.Android,
                "desktop" => CreateFlagResponseExperimentDevice.Desktop,
                "ios" => CreateFlagResponseExperimentDevice.Ios,
                "mweb" => CreateFlagResponseExperimentDevice.Mweb,
                _ => null,
            };
        }
    }
}