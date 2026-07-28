
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateMicrofrontendsResponseSandboxFailoverRegion
    {
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
    public static class UpdateMicrofrontendsResponseSandboxFailoverRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseSandboxFailoverRegion value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseSandboxFailoverRegion.Cle1 => "cle1",
                UpdateMicrofrontendsResponseSandboxFailoverRegion.Iad1 => "iad1",
                UpdateMicrofrontendsResponseSandboxFailoverRegion.Sfo1 => "sfo1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseSandboxFailoverRegion? ToEnum(string value)
        {
            return value switch
            {
                "cle1" => UpdateMicrofrontendsResponseSandboxFailoverRegion.Cle1,
                "iad1" => UpdateMicrofrontendsResponseSandboxFailoverRegion.Iad1,
                "sfo1" => UpdateMicrofrontendsResponseSandboxFailoverRegion.Sfo1,
                _ => null,
            };
        }
    }
}