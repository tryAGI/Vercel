
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of this cosmos doc instance, if blank, assume secret.<br/>
    /// Example: encrypted
    /// </summary>
    public enum UpdateSharedEnvVariableResponseUpdatedItemType
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
    public static class UpdateSharedEnvVariableResponseUpdatedItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateSharedEnvVariableResponseUpdatedItemType value)
        {
            return value switch
            {
                UpdateSharedEnvVariableResponseUpdatedItemType.Encrypted => "encrypted",
                UpdateSharedEnvVariableResponseUpdatedItemType.Plain => "plain",
                UpdateSharedEnvVariableResponseUpdatedItemType.Sensitive => "sensitive",
                UpdateSharedEnvVariableResponseUpdatedItemType.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateSharedEnvVariableResponseUpdatedItemType? ToEnum(string value)
        {
            return value switch
            {
                "encrypted" => UpdateSharedEnvVariableResponseUpdatedItemType.Encrypted,
                "plain" => UpdateSharedEnvVariableResponseUpdatedItemType.Plain,
                "sensitive" => UpdateSharedEnvVariableResponseUpdatedItemType.Sensitive,
                "system" => UpdateSharedEnvVariableResponseUpdatedItemType.System,
                _ => null,
            };
        }
    }
}