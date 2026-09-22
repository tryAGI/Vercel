#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AutoSDKShared90bb7952c1db9133 : global::System.IEquatable<AutoSDKShared90bb7952c1db9133>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKShared9c06dfe8dd59ad6d? Shared9c06dfe8dd59ad6d { get; init; }
#else
        public global::Vercel.AutoSDKShared9c06dfe8dd59ad6d? Shared9c06dfe8dd59ad6d { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shared9c06dfe8dd59ad6d))]
#endif
        public bool IsShared9c06dfe8dd59ad6d => Shared9c06dfe8dd59ad6d != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShared9c06dfe8dd59ad6d(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKShared9c06dfe8dd59ad6d? value)
        {
            value = Shared9c06dfe8dd59ad6d;
            return IsShared9c06dfe8dd59ad6d;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKShared9c06dfe8dd59ad6d PickShared9c06dfe8dd59ad6d() => IsShared9c06dfe8dd59ad6d
            ? Shared9c06dfe8dd59ad6d!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shared9c06dfe8dd59ad6d' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKShared383028c008cc4ae0? Shared383028c008cc4ae0 { get; init; }
#else
        public global::Vercel.AutoSDKShared383028c008cc4ae0? Shared383028c008cc4ae0 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shared383028c008cc4ae0))]
#endif
        public bool IsShared383028c008cc4ae0 => Shared383028c008cc4ae0 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShared383028c008cc4ae0(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKShared383028c008cc4ae0? value)
        {
            value = Shared383028c008cc4ae0;
            return IsShared383028c008cc4ae0;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKShared383028c008cc4ae0 PickShared383028c008cc4ae0() => IsShared383028c008cc4ae0
            ? Shared383028c008cc4ae0!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shared383028c008cc4ae0' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKShared90bb7952c1db9133(global::Vercel.AutoSDKShared9c06dfe8dd59ad6d value) => new AutoSDKShared90bb7952c1db9133((global::Vercel.AutoSDKShared9c06dfe8dd59ad6d?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKShared9c06dfe8dd59ad6d?(AutoSDKShared90bb7952c1db9133 @this) => @this.Shared9c06dfe8dd59ad6d;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared90bb7952c1db9133(global::Vercel.AutoSDKShared9c06dfe8dd59ad6d? value)
        {
            Shared9c06dfe8dd59ad6d = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKShared90bb7952c1db9133 FromShared9c06dfe8dd59ad6d(global::Vercel.AutoSDKShared9c06dfe8dd59ad6d? value) => new AutoSDKShared90bb7952c1db9133(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKShared90bb7952c1db9133(global::Vercel.AutoSDKShared383028c008cc4ae0 value) => new AutoSDKShared90bb7952c1db9133((global::Vercel.AutoSDKShared383028c008cc4ae0?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKShared383028c008cc4ae0?(AutoSDKShared90bb7952c1db9133 @this) => @this.Shared383028c008cc4ae0;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared90bb7952c1db9133(global::Vercel.AutoSDKShared383028c008cc4ae0? value)
        {
            Shared383028c008cc4ae0 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKShared90bb7952c1db9133 FromShared383028c008cc4ae0(global::Vercel.AutoSDKShared383028c008cc4ae0? value) => new AutoSDKShared90bb7952c1db9133(value);

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared90bb7952c1db9133(
            global::Vercel.AutoSDKShared9c06dfe8dd59ad6d? shared9c06dfe8dd59ad6d,
            global::Vercel.AutoSDKShared383028c008cc4ae0? shared383028c008cc4ae0
            )
        {
            Shared9c06dfe8dd59ad6d = shared9c06dfe8dd59ad6d;
            Shared383028c008cc4ae0 = shared383028c008cc4ae0;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Shared383028c008cc4ae0 as object ??
            Shared9c06dfe8dd59ad6d as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Shared9c06dfe8dd59ad6d?.ToString() ??
            Shared383028c008cc4ae0?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsShared9c06dfe8dd59ad6d && !IsShared383028c008cc4ae0 || !IsShared9c06dfe8dd59ad6d && IsShared383028c008cc4ae0;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vercel.AutoSDKShared9c06dfe8dd59ad6d, TResult>? shared9c06dfe8dd59ad6d = null,
            global::System.Func<global::Vercel.AutoSDKShared383028c008cc4ae0, TResult>? shared383028c008cc4ae0 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsShared9c06dfe8dd59ad6d && shared9c06dfe8dd59ad6d != null)
            {
                return shared9c06dfe8dd59ad6d(Shared9c06dfe8dd59ad6d!);
            }
            else if (IsShared383028c008cc4ae0 && shared383028c008cc4ae0 != null)
            {
                return shared383028c008cc4ae0(Shared383028c008cc4ae0!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vercel.AutoSDKShared9c06dfe8dd59ad6d>? shared9c06dfe8dd59ad6d = null,

            global::System.Action<global::Vercel.AutoSDKShared383028c008cc4ae0>? shared383028c008cc4ae0 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsShared9c06dfe8dd59ad6d)
            {
                shared9c06dfe8dd59ad6d?.Invoke(Shared9c06dfe8dd59ad6d!);
            }
            else if (IsShared383028c008cc4ae0)
            {
                shared383028c008cc4ae0?.Invoke(Shared383028c008cc4ae0!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vercel.AutoSDKShared9c06dfe8dd59ad6d>? shared9c06dfe8dd59ad6d = null,
            global::System.Action<global::Vercel.AutoSDKShared383028c008cc4ae0>? shared383028c008cc4ae0 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsShared9c06dfe8dd59ad6d)
            {
                shared9c06dfe8dd59ad6d?.Invoke(Shared9c06dfe8dd59ad6d!);
            }
            else if (IsShared383028c008cc4ae0)
            {
                shared383028c008cc4ae0?.Invoke(Shared383028c008cc4ae0!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Shared9c06dfe8dd59ad6d,
                typeof(global::Vercel.AutoSDKShared9c06dfe8dd59ad6d),
                Shared383028c008cc4ae0,
                typeof(global::Vercel.AutoSDKShared383028c008cc4ae0),
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
        public bool Equals(AutoSDKShared90bb7952c1db9133 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKShared9c06dfe8dd59ad6d?>.Default.Equals(Shared9c06dfe8dd59ad6d, other.Shared9c06dfe8dd59ad6d) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKShared383028c008cc4ae0?>.Default.Equals(Shared383028c008cc4ae0, other.Shared383028c008cc4ae0)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AutoSDKShared90bb7952c1db9133 obj1, AutoSDKShared90bb7952c1db9133 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AutoSDKShared90bb7952c1db9133>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AutoSDKShared90bb7952c1db9133 obj1, AutoSDKShared90bb7952c1db9133 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutoSDKShared90bb7952c1db9133 o && Equals(o);
        }
    }
}
