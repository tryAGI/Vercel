
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateMicrofrontendsResponseSandboxRegion
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
    public static class UpdateMicrofrontendsResponseSandboxRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseSandboxRegion value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseSandboxRegion.Cdg1 => "cdg1",
                UpdateMicrofrontendsResponseSandboxRegion.Cle1 => "cle1",
                UpdateMicrofrontendsResponseSandboxRegion.Iad1 => "iad1",
                UpdateMicrofrontendsResponseSandboxRegion.Sfo1 => "sfo1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseSandboxRegion? ToEnum(string value)
        {
            return value switch
            {
                "cdg1" => UpdateMicrofrontendsResponseSandboxRegion.Cdg1,
                "cle1" => UpdateMicrofrontendsResponseSandboxRegion.Cle1,
                "iad1" => UpdateMicrofrontendsResponseSandboxRegion.Iad1,
                "sfo1" => UpdateMicrofrontendsResponseSandboxRegion.Sfo1,
                _ => null,
            };
        }
    }
}