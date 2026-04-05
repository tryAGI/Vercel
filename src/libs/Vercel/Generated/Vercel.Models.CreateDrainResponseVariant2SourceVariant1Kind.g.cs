
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDrainResponseVariant2SourceVariant1Kind
    {
        /// <summary>
        /// 
        /// </summary>
        SelfServed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDrainResponseVariant2SourceVariant1KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDrainResponseVariant2SourceVariant1Kind value)
        {
            return value switch
            {
                CreateDrainResponseVariant2SourceVariant1Kind.SelfServed => "self-served",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDrainResponseVariant2SourceVariant1Kind? ToEnum(string value)
        {
            return value switch
            {
                "self-served" => CreateDrainResponseVariant2SourceVariant1Kind.SelfServed,
                _ => null,
            };
        }
    }
}