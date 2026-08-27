
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectAliaEnvironment
    {
        /// <summary>
        ///
        /// </summary>
        Preview,
        /// <summary>
        ///
        /// </summary>
        Production,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetMicrofrontendsInGroupResponseProjectAliaEnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectAliaEnvironment value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectAliaEnvironment.Preview => "preview",
                GetMicrofrontendsInGroupResponseProjectAliaEnvironment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectAliaEnvironment? ToEnum(string value)
        {
            return value switch
            {
                "preview" => GetMicrofrontendsInGroupResponseProjectAliaEnvironment.Preview,
                "production" => GetMicrofrontendsInGroupResponseProjectAliaEnvironment.Production,
                _ => null,
            };
        }
    }
}