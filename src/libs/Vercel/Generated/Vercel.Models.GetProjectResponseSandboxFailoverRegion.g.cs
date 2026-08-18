
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectResponseSandboxFailoverRegion
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
    public static class GetProjectResponseSandboxFailoverRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseSandboxFailoverRegion value)
        {
            return value switch
            {
                GetProjectResponseSandboxFailoverRegion.Cdg1 => "cdg1",
                GetProjectResponseSandboxFailoverRegion.Cle1 => "cle1",
                GetProjectResponseSandboxFailoverRegion.Iad1 => "iad1",
                GetProjectResponseSandboxFailoverRegion.Sfo1 => "sfo1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseSandboxFailoverRegion? ToEnum(string value)
        {
            return value switch
            {
                "cdg1" => GetProjectResponseSandboxFailoverRegion.Cdg1,
                "cle1" => GetProjectResponseSandboxFailoverRegion.Cle1,
                "iad1" => GetProjectResponseSandboxFailoverRegion.Iad1,
                "sfo1" => GetProjectResponseSandboxFailoverRegion.Sfo1,
                _ => null,
            };
        }
    }
}