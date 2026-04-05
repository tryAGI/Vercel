
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of environment variable<br/>
    /// Example: plain
    /// </summary>
    public enum CreateProjectEnvRequestItemType
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
    public static class CreateProjectEnvRequestItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectEnvRequestItemType value)
        {
            return value switch
            {
                CreateProjectEnvRequestItemType.Encrypted => "encrypted",
                CreateProjectEnvRequestItemType.Plain => "plain",
                CreateProjectEnvRequestItemType.Sensitive => "sensitive",
                CreateProjectEnvRequestItemType.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectEnvRequestItemType? ToEnum(string value)
        {
            return value switch
            {
                "encrypted" => CreateProjectEnvRequestItemType.Encrypted,
                "plain" => CreateProjectEnvRequestItemType.Plain,
                "sensitive" => CreateProjectEnvRequestItemType.Sensitive,
                "system" => CreateProjectEnvRequestItemType.System,
                _ => null,
            };
        }
    }
}