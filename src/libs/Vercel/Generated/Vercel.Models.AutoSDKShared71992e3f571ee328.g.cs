#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AutoSDKShared71992e3f571ee328 : global::System.IEquatable<AutoSDKShared71992e3f571ee328>
    {
        /// <summary>
        /// Services detected during build from vercel.json experimentalServices or auto-detected from project structure. Used to inject service URLs as environment variables at runtime.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKShared78bd7b18568312c4? Shared78bd7b18568312c4 { get; init; }
#else
        public global::Vercel.AutoSDKShared78bd7b18568312c4? Shared78bd7b18568312c4 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shared78bd7b18568312c4))]
#endif
        public bool IsShared78bd7b18568312c4 => Shared78bd7b18568312c4 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShared78bd7b18568312c4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKShared78bd7b18568312c4? value)
        {
            value = Shared78bd7b18568312c4;
            return IsShared78bd7b18568312c4;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKShared78bd7b18568312c4 PickShared78bd7b18568312c4() => Shared78bd7b18568312c4 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shared78bd7b18568312c4' but the value was {ToString()}.");

        /// <summary>
        /// Services detected during build from vercel.json experimentalServices or auto-detected from project structure. Used to inject service URLs as environment variables at runtime.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKShared6ca7f4005d33343f? Shared6ca7f4005d33343f { get; init; }
#else
        public global::Vercel.AutoSDKShared6ca7f4005d33343f? Shared6ca7f4005d33343f { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shared6ca7f4005d33343f))]
#endif
        public bool IsShared6ca7f4005d33343f => Shared6ca7f4005d33343f != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShared6ca7f4005d33343f(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKShared6ca7f4005d33343f? value)
        {
            value = Shared6ca7f4005d33343f;
            return IsShared6ca7f4005d33343f;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKShared6ca7f4005d33343f PickShared6ca7f4005d33343f() => Shared6ca7f4005d33343f is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shared6ca7f4005d33343f' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKShared71992e3f571ee328(global::Vercel.AutoSDKShared78bd7b18568312c4 value) => new AutoSDKShared71992e3f571ee328((global::Vercel.AutoSDKShared78bd7b18568312c4?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKShared78bd7b18568312c4?(AutoSDKShared71992e3f571ee328 @this) => @this.Shared78bd7b18568312c4;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared71992e3f571ee328(global::Vercel.AutoSDKShared78bd7b18568312c4? value)
        {
            Shared78bd7b18568312c4 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKShared71992e3f571ee328 FromShared78bd7b18568312c4(global::Vercel.AutoSDKShared78bd7b18568312c4? value) => new AutoSDKShared71992e3f571ee328(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKShared71992e3f571ee328(global::Vercel.AutoSDKShared6ca7f4005d33343f value) => new AutoSDKShared71992e3f571ee328((global::Vercel.AutoSDKShared6ca7f4005d33343f?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKShared6ca7f4005d33343f?(AutoSDKShared71992e3f571ee328 @this) => @this.Shared6ca7f4005d33343f;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared71992e3f571ee328(global::Vercel.AutoSDKShared6ca7f4005d33343f? value)
        {
            Shared6ca7f4005d33343f = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKShared71992e3f571ee328 FromShared6ca7f4005d33343f(global::Vercel.AutoSDKShared6ca7f4005d33343f? value) => new AutoSDKShared71992e3f571ee328(value);

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared71992e3f571ee328(
            global::Vercel.AutoSDKShared78bd7b18568312c4? shared78bd7b18568312c4,
            global::Vercel.AutoSDKShared6ca7f4005d33343f? shared6ca7f4005d33343f
            )
        {
            Shared78bd7b18568312c4 = shared78bd7b18568312c4;
            Shared6ca7f4005d33343f = shared6ca7f4005d33343f;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Shared6ca7f4005d33343f as object ??
            Shared78bd7b18568312c4 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Shared78bd7b18568312c4?.ToString() ??
            Shared6ca7f4005d33343f?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsShared78bd7b18568312c4 && !IsShared6ca7f4005d33343f || !IsShared78bd7b18568312c4 && IsShared6ca7f4005d33343f;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vercel.AutoSDKShared78bd7b18568312c4, TResult>? shared78bd7b18568312c4 = null,
            global::System.Func<global::Vercel.AutoSDKShared6ca7f4005d33343f, TResult>? shared6ca7f4005d33343f = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shared78bd7b18568312c4 is { } __value0 && shared78bd7b18568312c4 != null)
            {
                return shared78bd7b18568312c4(__value0);
            }
            else if (Shared6ca7f4005d33343f is { } __value1 && shared6ca7f4005d33343f != null)
            {
                return shared6ca7f4005d33343f(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vercel.AutoSDKShared78bd7b18568312c4>? shared78bd7b18568312c4 = null,

            global::System.Action<global::Vercel.AutoSDKShared6ca7f4005d33343f>? shared6ca7f4005d33343f = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shared78bd7b18568312c4 is { } __value0)
            {
                shared78bd7b18568312c4?.Invoke(__value0);
            }
            else if (Shared6ca7f4005d33343f is { } __value1)
            {
                shared6ca7f4005d33343f?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vercel.AutoSDKShared78bd7b18568312c4>? shared78bd7b18568312c4 = null,
            global::System.Action<global::Vercel.AutoSDKShared6ca7f4005d33343f>? shared6ca7f4005d33343f = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shared78bd7b18568312c4 is { } __value0)
            {
                shared78bd7b18568312c4?.Invoke(__value0);
            }
            else if (Shared6ca7f4005d33343f is { } __value1)
            {
                shared6ca7f4005d33343f?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Shared78bd7b18568312c4,
                typeof(global::Vercel.AutoSDKShared78bd7b18568312c4),
                Shared6ca7f4005d33343f,
                typeof(global::Vercel.AutoSDKShared6ca7f4005d33343f),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(AutoSDKShared71992e3f571ee328 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKShared78bd7b18568312c4?>.Default.Equals(Shared78bd7b18568312c4, other.Shared78bd7b18568312c4) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKShared6ca7f4005d33343f?>.Default.Equals(Shared6ca7f4005d33343f, other.Shared6ca7f4005d33343f)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AutoSDKShared71992e3f571ee328 obj1, AutoSDKShared71992e3f571ee328 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AutoSDKShared71992e3f571ee328>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AutoSDKShared71992e3f571ee328 obj1, AutoSDKShared71992e3f571ee328 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutoSDKShared71992e3f571ee328 o && Equals(o);
        }
    }
}
