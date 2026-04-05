
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum EditProjectEnvResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        Encrypted,
        /// <summary>
        /// 
        /// </summary>
        Plain,
        /// <summary>
        /// 
        /// </summary>
        Secret,
        /// <summary>
        /// 
        /// </summary>
        Sensitive,
        /// <summary>
        /// 
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditProjectEnvResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditProjectEnvResponseType value)
        {
            return value switch
            {
                EditProjectEnvResponseType.Encrypted => "encrypted",
                EditProjectEnvResponseType.Plain => "plain",
                EditProjectEnvResponseType.Secret => "secret",
                EditProjectEnvResponseType.Sensitive => "sensitive",
                EditProjectEnvResponseType.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditProjectEnvResponseType? ToEnum(string value)
        {
            return value switch
            {
                "encrypted" => EditProjectEnvResponseType.Encrypted,
                "plain" => EditProjectEnvResponseType.Plain,
                "secret" => EditProjectEnvResponseType.Secret,
                "sensitive" => EditProjectEnvResponseType.Sensitive,
                "system" => EditProjectEnvResponseType.System,
                _ => null,
            };
        }
    }
}