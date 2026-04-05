
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectLinkVariant5Type
    {
        /// <summary>
        /// 
        /// </summary>
        Bitbucket,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetMicrofrontendsInGroupResponseProjectLinkVariant5TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectLinkVariant5Type value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectLinkVariant5Type.Bitbucket => "bitbucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectLinkVariant5Type? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => GetMicrofrontendsInGroupResponseProjectLinkVariant5Type.Bitbucket,
                _ => null,
            };
        }
    }
}