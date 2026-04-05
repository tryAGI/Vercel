
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Environment to apply sampling to
    /// </summary>
    public enum CreateDrainRequestSamplingItemEnv
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
    public static class CreateDrainRequestSamplingItemEnvExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDrainRequestSamplingItemEnv value)
        {
            return value switch
            {
                CreateDrainRequestSamplingItemEnv.Preview => "preview",
                CreateDrainRequestSamplingItemEnv.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDrainRequestSamplingItemEnv? ToEnum(string value)
        {
            return value switch
            {
                "preview" => CreateDrainRequestSamplingItemEnv.Preview,
                "production" => CreateDrainRequestSamplingItemEnv.Production,
                _ => null,
            };
        }
    }
}