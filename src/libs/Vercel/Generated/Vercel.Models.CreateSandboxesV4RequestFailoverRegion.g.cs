
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSandboxesV4RequestFailoverRegion
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
    public static class CreateSandboxesV4RequestFailoverRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSandboxesV4RequestFailoverRegion value)
        {
            return value switch
            {
                CreateSandboxesV4RequestFailoverRegion.Cdg1 => "cdg1",
                CreateSandboxesV4RequestFailoverRegion.Cle1 => "cle1",
                CreateSandboxesV4RequestFailoverRegion.Iad1 => "iad1",
                CreateSandboxesV4RequestFailoverRegion.Sfo1 => "sfo1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSandboxesV4RequestFailoverRegion? ToEnum(string value)
        {
            return value switch
            {
                "cdg1" => CreateSandboxesV4RequestFailoverRegion.Cdg1,
                "cle1" => CreateSandboxesV4RequestFailoverRegion.Cle1,
                "iad1" => CreateSandboxesV4RequestFailoverRegion.Iad1,
                "sfo1" => CreateSandboxesV4RequestFailoverRegion.Sfo1,
                _ => null,
            };
        }
    }
}