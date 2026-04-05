
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateDrainResponseVariant2SamplingItemEnv
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
    public static class UpdateDrainResponseVariant2SamplingItemEnvExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDrainResponseVariant2SamplingItemEnv value)
        {
            return value switch
            {
                UpdateDrainResponseVariant2SamplingItemEnv.Preview => "preview",
                UpdateDrainResponseVariant2SamplingItemEnv.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDrainResponseVariant2SamplingItemEnv? ToEnum(string value)
        {
            return value switch
            {
                "preview" => UpdateDrainResponseVariant2SamplingItemEnv.Preview,
                "production" => UpdateDrainResponseVariant2SamplingItemEnv.Production,
                _ => null,
            };
        }
    }
}