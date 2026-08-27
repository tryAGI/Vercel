
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectAliaTarget
    {
        /// <summary>
        ///
        /// </summary>
        Preview,
        /// <summary>
        ///
        /// </summary>
        Production,
        /// <summary>
        ///
        /// </summary>
        Staging,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetMicrofrontendsInGroupResponseProjectAliaTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectAliaTarget value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectAliaTarget.Preview => "PREVIEW",
                GetMicrofrontendsInGroupResponseProjectAliaTarget.Production => "PRODUCTION",
                GetMicrofrontendsInGroupResponseProjectAliaTarget.Staging => "STAGING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectAliaTarget? ToEnum(string value)
        {
            return value switch
            {
                "PREVIEW" => GetMicrofrontendsInGroupResponseProjectAliaTarget.Preview,
                "PRODUCTION" => GetMicrofrontendsInGroupResponseProjectAliaTarget.Production,
                "STAGING" => GetMicrofrontendsInGroupResponseProjectAliaTarget.Staging,
                _ => null,
            };
        }
    }
}