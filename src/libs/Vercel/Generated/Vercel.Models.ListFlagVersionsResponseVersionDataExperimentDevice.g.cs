
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListFlagVersionsResponseVersionDataExperimentDevice
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
    public static class ListFlagVersionsResponseVersionDataExperimentDeviceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListFlagVersionsResponseVersionDataExperimentDevice value)
        {
            return value switch
            {
                ListFlagVersionsResponseVersionDataExperimentDevice.Android => "android",
                ListFlagVersionsResponseVersionDataExperimentDevice.Desktop => "desktop",
                ListFlagVersionsResponseVersionDataExperimentDevice.Ios => "ios",
                ListFlagVersionsResponseVersionDataExperimentDevice.Mweb => "mweb",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListFlagVersionsResponseVersionDataExperimentDevice? ToEnum(string value)
        {
            return value switch
            {
                "android" => ListFlagVersionsResponseVersionDataExperimentDevice.Android,
                "desktop" => ListFlagVersionsResponseVersionDataExperimentDevice.Desktop,
                "ios" => ListFlagVersionsResponseVersionDataExperimentDevice.Ios,
                "mweb" => ListFlagVersionsResponseVersionDataExperimentDevice.Mweb,
                _ => null,
            };
        }
    }
}