
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum FilterProjectEnvsResponseVariant1Type
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
    public static class FilterProjectEnvsResponseVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilterProjectEnvsResponseVariant1Type value)
        {
            return value switch
            {
                FilterProjectEnvsResponseVariant1Type.Encrypted => "encrypted",
                FilterProjectEnvsResponseVariant1Type.Plain => "plain",
                FilterProjectEnvsResponseVariant1Type.Secret => "secret",
                FilterProjectEnvsResponseVariant1Type.Sensitive => "sensitive",
                FilterProjectEnvsResponseVariant1Type.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilterProjectEnvsResponseVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "encrypted" => FilterProjectEnvsResponseVariant1Type.Encrypted,
                "plain" => FilterProjectEnvsResponseVariant1Type.Plain,
                "secret" => FilterProjectEnvsResponseVariant1Type.Secret,
                "sensitive" => FilterProjectEnvsResponseVariant1Type.Sensitive,
                "system" => FilterProjectEnvsResponseVariant1Type.System,
                _ => null,
            };
        }
    }
}