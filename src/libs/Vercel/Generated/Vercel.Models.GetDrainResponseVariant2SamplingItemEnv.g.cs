
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDrainResponseVariant2SamplingItemEnv
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
    public static class GetDrainResponseVariant2SamplingItemEnvExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDrainResponseVariant2SamplingItemEnv value)
        {
            return value switch
            {
                GetDrainResponseVariant2SamplingItemEnv.Preview => "preview",
                GetDrainResponseVariant2SamplingItemEnv.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDrainResponseVariant2SamplingItemEnv? ToEnum(string value)
        {
            return value switch
            {
                "preview" => GetDrainResponseVariant2SamplingItemEnv.Preview,
                "production" => GetDrainResponseVariant2SamplingItemEnv.Production,
                _ => null,
            };
        }
    }
}