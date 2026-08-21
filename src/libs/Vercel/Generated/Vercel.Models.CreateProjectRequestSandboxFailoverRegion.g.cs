
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectRequestSandboxFailoverRegion
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
    public static class CreateProjectRequestSandboxFailoverRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectRequestSandboxFailoverRegion value)
        {
            return value switch
            {
                CreateProjectRequestSandboxFailoverRegion.Cdg1 => "cdg1",
                CreateProjectRequestSandboxFailoverRegion.Cle1 => "cle1",
                CreateProjectRequestSandboxFailoverRegion.Iad1 => "iad1",
                CreateProjectRequestSandboxFailoverRegion.Sfo1 => "sfo1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectRequestSandboxFailoverRegion? ToEnum(string value)
        {
            return value switch
            {
                "cdg1" => CreateProjectRequestSandboxFailoverRegion.Cdg1,
                "cle1" => CreateProjectRequestSandboxFailoverRegion.Cle1,
                "iad1" => CreateProjectRequestSandboxFailoverRegion.Iad1,
                "sfo1" => CreateProjectRequestSandboxFailoverRegion.Sfo1,
                _ => null,
            };
        }
    }
}