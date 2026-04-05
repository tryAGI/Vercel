
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateStaticIpsResponseItemEnvId
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
    public static class UpdateStaticIpsResponseItemEnvIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateStaticIpsResponseItemEnvId value)
        {
            return value switch
            {
                UpdateStaticIpsResponseItemEnvId.Preview => "preview",
                UpdateStaticIpsResponseItemEnvId.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateStaticIpsResponseItemEnvId? ToEnum(string value)
        {
            return value switch
            {
                "preview" => UpdateStaticIpsResponseItemEnvId.Preview,
                "production" => UpdateStaticIpsResponseItemEnvId.Production,
                _ => null,
            };
        }
    }
}