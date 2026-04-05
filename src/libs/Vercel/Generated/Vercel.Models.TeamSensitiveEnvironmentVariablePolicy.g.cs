
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Sensitive environment variable policy for this team
    /// </summary>
    public enum TeamSensitiveEnvironmentVariablePolicy
    {
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        Off,
        /// <summary>
        /// 
        /// </summary>
        On,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TeamSensitiveEnvironmentVariablePolicyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamSensitiveEnvironmentVariablePolicy value)
        {
            return value switch
            {
                TeamSensitiveEnvironmentVariablePolicy.Default => "default",
                TeamSensitiveEnvironmentVariablePolicy.Off => "off",
                TeamSensitiveEnvironmentVariablePolicy.On => "on",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamSensitiveEnvironmentVariablePolicy? ToEnum(string value)
        {
            return value switch
            {
                "default" => TeamSensitiveEnvironmentVariablePolicy.Default,
                "off" => TeamSensitiveEnvironmentVariablePolicy.Off,
                "on" => TeamSensitiveEnvironmentVariablePolicy.On,
                _ => null,
            };
        }
    }
}