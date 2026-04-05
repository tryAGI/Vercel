
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateDrainResponseVariant1SamplingItemEnv
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
    public static class UpdateDrainResponseVariant1SamplingItemEnvExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDrainResponseVariant1SamplingItemEnv value)
        {
            return value switch
            {
                UpdateDrainResponseVariant1SamplingItemEnv.Preview => "preview",
                UpdateDrainResponseVariant1SamplingItemEnv.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDrainResponseVariant1SamplingItemEnv? ToEnum(string value)
        {
            return value switch
            {
                "preview" => UpdateDrainResponseVariant1SamplingItemEnv.Preview,
                "production" => UpdateDrainResponseVariant1SamplingItemEnv.Production,
                _ => null,
            };
        }
    }
}