
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectSandboxFailoverRegion
    {
        /// <summary>
        /// 
        /// </summary>
        Cdg1,
        /// <summary>
        /// 
        /// </summary>
        Cle1,
        /// <summary>
        /// 
        /// </summary>
        Iad1,
        /// <summary>
        /// 
        /// </summary>
        Sfo1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetMicrofrontendsInGroupResponseProjectSandboxFailoverRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectSandboxFailoverRegion value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectSandboxFailoverRegion.Cdg1 => "cdg1",
                GetMicrofrontendsInGroupResponseProjectSandboxFailoverRegion.Cle1 => "cle1",
                GetMicrofrontendsInGroupResponseProjectSandboxFailoverRegion.Iad1 => "iad1",
                GetMicrofrontendsInGroupResponseProjectSandboxFailoverRegion.Sfo1 => "sfo1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectSandboxFailoverRegion? ToEnum(string value)
        {
            return value switch
            {
                "cdg1" => GetMicrofrontendsInGroupResponseProjectSandboxFailoverRegion.Cdg1,
                "cle1" => GetMicrofrontendsInGroupResponseProjectSandboxFailoverRegion.Cle1,
                "iad1" => GetMicrofrontendsInGroupResponseProjectSandboxFailoverRegion.Iad1,
                "sfo1" => GetMicrofrontendsInGroupResponseProjectSandboxFailoverRegion.Sfo1,
                _ => null,
            };
        }
    }
}