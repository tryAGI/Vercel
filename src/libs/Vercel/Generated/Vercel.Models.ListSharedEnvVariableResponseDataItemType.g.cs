
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of this cosmos doc instance, if blank, assume secret.<br/>
    /// Example: encrypted
    /// </summary>
    public enum ListSharedEnvVariableResponseDataItemType
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
    public static class ListSharedEnvVariableResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListSharedEnvVariableResponseDataItemType value)
        {
            return value switch
            {
                ListSharedEnvVariableResponseDataItemType.Encrypted => "encrypted",
                ListSharedEnvVariableResponseDataItemType.Plain => "plain",
                ListSharedEnvVariableResponseDataItemType.Sensitive => "sensitive",
                ListSharedEnvVariableResponseDataItemType.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListSharedEnvVariableResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "encrypted" => ListSharedEnvVariableResponseDataItemType.Encrypted,
                "plain" => ListSharedEnvVariableResponseDataItemType.Plain,
                "sensitive" => ListSharedEnvVariableResponseDataItemType.Sensitive,
                "system" => ListSharedEnvVariableResponseDataItemType.System,
                _ => null,
            };
        }
    }
}