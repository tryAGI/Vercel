
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of environment variable<br/>
    /// Example: plain
    /// </summary>
    public enum CreateProjectEnvRequestType
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
    public static class CreateProjectEnvRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectEnvRequestType value)
        {
            return value switch
            {
                CreateProjectEnvRequestType.Encrypted => "encrypted",
                CreateProjectEnvRequestType.Plain => "plain",
                CreateProjectEnvRequestType.Sensitive => "sensitive",
                CreateProjectEnvRequestType.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectEnvRequestType? ToEnum(string value)
        {
            return value switch
            {
                "encrypted" => CreateProjectEnvRequestType.Encrypted,
                "plain" => CreateProjectEnvRequestType.Plain,
                "sensitive" => CreateProjectEnvRequestType.Sensitive,
                "system" => CreateProjectEnvRequestType.System,
                _ => null,
            };
        }
    }
}