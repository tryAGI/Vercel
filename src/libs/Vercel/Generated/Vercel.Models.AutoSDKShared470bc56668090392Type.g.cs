
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared470bc56668090392Type
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
    public static class AutoSDKShared470bc56668090392TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared470bc56668090392Type value)
        {
            return value switch
            {
                AutoSDKShared470bc56668090392Type.Encrypted => "encrypted",
                AutoSDKShared470bc56668090392Type.Plain => "plain",
                AutoSDKShared470bc56668090392Type.Secret => "secret",
                AutoSDKShared470bc56668090392Type.Sensitive => "sensitive",
                AutoSDKShared470bc56668090392Type.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared470bc56668090392Type? ToEnum(string value)
        {
            return value switch
            {
                "encrypted" => AutoSDKShared470bc56668090392Type.Encrypted,
                "plain" => AutoSDKShared470bc56668090392Type.Plain,
                "secret" => AutoSDKShared470bc56668090392Type.Secret,
                "sensitive" => AutoSDKShared470bc56668090392Type.Sensitive,
                "system" => AutoSDKShared470bc56668090392Type.System,
                _ => null,
            };
        }
    }
}