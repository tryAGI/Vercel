
#nullable enable

namespace Vercel
{
    /// <summary>
    /// If true, the environment variable value will be decrypted<br/>
    /// Example: true
    /// </summary>
    public enum FilterProjectEnvsDecrypt
    {
        /// <summary>
        /// 
        /// </summary>
        False,
        /// <summary>
        /// 
        /// </summary>
        True,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FilterProjectEnvsDecryptExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilterProjectEnvsDecrypt value)
        {
            return value switch
            {
                FilterProjectEnvsDecrypt.False => "false",
                FilterProjectEnvsDecrypt.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilterProjectEnvsDecrypt? ToEnum(string value)
        {
            return value switch
            {
                "false" => FilterProjectEnvsDecrypt.False,
                "true" => FilterProjectEnvsDecrypt.True,
                _ => null,
            };
        }
    }
}