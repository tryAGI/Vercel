
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectSandboxRegion
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
    public static class GetMicrofrontendsInGroupResponseProjectSandboxRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectSandboxRegion value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectSandboxRegion.Cdg1 => "cdg1",
                GetMicrofrontendsInGroupResponseProjectSandboxRegion.Cle1 => "cle1",
                GetMicrofrontendsInGroupResponseProjectSandboxRegion.Iad1 => "iad1",
                GetMicrofrontendsInGroupResponseProjectSandboxRegion.Sfo1 => "sfo1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectSandboxRegion? ToEnum(string value)
        {
            return value switch
            {
                "cdg1" => GetMicrofrontendsInGroupResponseProjectSandboxRegion.Cdg1,
                "cle1" => GetMicrofrontendsInGroupResponseProjectSandboxRegion.Cle1,
                "iad1" => GetMicrofrontendsInGroupResponseProjectSandboxRegion.Iad1,
                "sfo1" => GetMicrofrontendsInGroupResponseProjectSandboxRegion.Sfo1,
                _ => null,
            };
        }
    }
}