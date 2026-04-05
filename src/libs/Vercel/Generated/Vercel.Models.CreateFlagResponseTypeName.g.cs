
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateFlagResponseTypeName
    {
        /// <summary>
        /// 
        /// </summary>
        Flag,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateFlagResponseTypeNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateFlagResponseTypeName value)
        {
            return value switch
            {
                CreateFlagResponseTypeName.Flag => "flag",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateFlagResponseTypeName? ToEnum(string value)
        {
            return value switch
            {
                "flag" => CreateFlagResponseTypeName.Flag,
                _ => null,
            };
        }
    }
}