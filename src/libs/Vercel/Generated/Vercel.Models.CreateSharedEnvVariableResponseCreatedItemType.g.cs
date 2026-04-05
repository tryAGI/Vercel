
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of this cosmos doc instance, if blank, assume secret.<br/>
    /// Example: encrypted
    /// </summary>
    public enum CreateSharedEnvVariableResponseCreatedItemType
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
    public static class CreateSharedEnvVariableResponseCreatedItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSharedEnvVariableResponseCreatedItemType value)
        {
            return value switch
            {
                CreateSharedEnvVariableResponseCreatedItemType.Encrypted => "encrypted",
                CreateSharedEnvVariableResponseCreatedItemType.Plain => "plain",
                CreateSharedEnvVariableResponseCreatedItemType.Sensitive => "sensitive",
                CreateSharedEnvVariableResponseCreatedItemType.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSharedEnvVariableResponseCreatedItemType? ToEnum(string value)
        {
            return value switch
            {
                "encrypted" => CreateSharedEnvVariableResponseCreatedItemType.Encrypted,
                "plain" => CreateSharedEnvVariableResponseCreatedItemType.Plain,
                "sensitive" => CreateSharedEnvVariableResponseCreatedItemType.Sensitive,
                "system" => CreateSharedEnvVariableResponseCreatedItemType.System,
                _ => null,
            };
        }
    }
}