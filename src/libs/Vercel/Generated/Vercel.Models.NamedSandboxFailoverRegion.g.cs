
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The regions the sandbox fails over to. Empty when it does not fail over.<br/>
    /// Example: [sfo1, cle1]
    /// </summary>
    public enum NamedSandboxFailoverRegion
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
    public static class NamedSandboxFailoverRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NamedSandboxFailoverRegion value)
        {
            return value switch
            {
                NamedSandboxFailoverRegion.Cdg1 => "cdg1",
                NamedSandboxFailoverRegion.Cle1 => "cle1",
                NamedSandboxFailoverRegion.Iad1 => "iad1",
                NamedSandboxFailoverRegion.Sfo1 => "sfo1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NamedSandboxFailoverRegion? ToEnum(string value)
        {
            return value switch
            {
                "cdg1" => NamedSandboxFailoverRegion.Cdg1,
                "cle1" => NamedSandboxFailoverRegion.Cle1,
                "iad1" => NamedSandboxFailoverRegion.Iad1,
                "sfo1" => NamedSandboxFailoverRegion.Sfo1,
                _ => null,
            };
        }
    }
}