
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateLogDrainResponseSourceVariant1Kind
    {
        /// <summary>
        /// 
        /// </summary>
        SelfServed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateLogDrainResponseSourceVariant1KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateLogDrainResponseSourceVariant1Kind value)
        {
            return value switch
            {
                CreateLogDrainResponseSourceVariant1Kind.SelfServed => "self-served",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateLogDrainResponseSourceVariant1Kind? ToEnum(string value)
        {
            return value switch
            {
                "self-served" => CreateLogDrainResponseSourceVariant1Kind.SelfServed,
                _ => null,
            };
        }
    }
}