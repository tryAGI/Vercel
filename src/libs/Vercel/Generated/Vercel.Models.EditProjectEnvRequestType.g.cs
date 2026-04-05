
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of environment variable<br/>
    /// Example: plain
    /// </summary>
    public enum EditProjectEnvRequestType
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
        Sensitive,
        /// <summary>
        /// 
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditProjectEnvRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditProjectEnvRequestType value)
        {
            return value switch
            {
                EditProjectEnvRequestType.Encrypted => "encrypted",
                EditProjectEnvRequestType.Plain => "plain",
                EditProjectEnvRequestType.Sensitive => "sensitive",
                EditProjectEnvRequestType.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditProjectEnvRequestType? ToEnum(string value)
        {
            return value switch
            {
                "encrypted" => EditProjectEnvRequestType.Encrypted,
                "plain" => EditProjectEnvRequestType.Plain,
                "sensitive" => EditProjectEnvRequestType.Sensitive,
                "system" => EditProjectEnvRequestType.System,
                _ => null,
            };
        }
    }
}