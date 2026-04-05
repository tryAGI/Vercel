
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Environment to apply sampling to
    /// </summary>
    public enum UpdateDrainRequestSamplingItemEnv
    {
        /// <summary>
        /// 
        /// </summary>
        Preview,
        /// <summary>
        /// 
        /// </summary>
        Production,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateDrainRequestSamplingItemEnvExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDrainRequestSamplingItemEnv value)
        {
            return value switch
            {
                UpdateDrainRequestSamplingItemEnv.Preview => "preview",
                UpdateDrainRequestSamplingItemEnv.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDrainRequestSamplingItemEnv? ToEnum(string value)
        {
            return value switch
            {
                "preview" => UpdateDrainRequestSamplingItemEnv.Preview,
                "production" => UpdateDrainRequestSamplingItemEnv.Production,
                _ => null,
            };
        }
    }
}