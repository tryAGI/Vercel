
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectEnvResponseCreatedType
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
    public static class CreateProjectEnvResponseCreatedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectEnvResponseCreatedType value)
        {
            return value switch
            {
                CreateProjectEnvResponseCreatedType.Encrypted => "encrypted",
                CreateProjectEnvResponseCreatedType.Plain => "plain",
                CreateProjectEnvResponseCreatedType.Secret => "secret",
                CreateProjectEnvResponseCreatedType.Sensitive => "sensitive",
                CreateProjectEnvResponseCreatedType.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectEnvResponseCreatedType? ToEnum(string value)
        {
            return value switch
            {
                "encrypted" => CreateProjectEnvResponseCreatedType.Encrypted,
                "plain" => CreateProjectEnvResponseCreatedType.Plain,
                "secret" => CreateProjectEnvResponseCreatedType.Secret,
                "sensitive" => CreateProjectEnvResponseCreatedType.Sensitive,
                "system" => CreateProjectEnvResponseCreatedType.System,
                _ => null,
            };
        }
    }
}