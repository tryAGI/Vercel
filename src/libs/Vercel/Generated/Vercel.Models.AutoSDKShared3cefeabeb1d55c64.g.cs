#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AutoSDKShared3cefeabeb1d55c64 : global::System.IEquatable<AutoSDKShared3cefeabeb1d55c64>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared08bf5d361fc08707>? Shared6a1866dc1efffce0 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared08bf5d361fc08707>? Shared6a1866dc1efffce0 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shared6a1866dc1efffce0))]
#endif
        public bool IsShared6a1866dc1efffce0 => Shared6a1866dc1efffce0 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShared6a1866dc1efffce0(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared08bf5d361fc08707>? value)
        {
            value = Shared6a1866dc1efffce0;
            return IsShared6a1866dc1efffce0;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared08bf5d361fc08707> PickShared6a1866dc1efffce0() => IsShared6a1866dc1efffce0
            ? Shared6a1866dc1efffce0!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shared6a1866dc1efffce0' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKShared3cefeabeb1d55c64Variant22>? AutoSDKShared3cefeabeb1d55c64Variant2 { get; init; }
#else
        public global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKShared3cefeabeb1d55c64Variant22>? AutoSDKShared3cefeabeb1d55c64Variant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AutoSDKShared3cefeabeb1d55c64Variant2))]
#endif
        public bool IsAutoSDKShared3cefeabeb1d55c64Variant2 => AutoSDKShared3cefeabeb1d55c64Variant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAutoSDKShared3cefeabeb1d55c64Variant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKShared3cefeabeb1d55c64Variant22>? value)
        {
            value = AutoSDKShared3cefeabeb1d55c64Variant2;
            return IsAutoSDKShared3cefeabeb1d55c64Variant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKShared3cefeabeb1d55c64Variant22> PickAutoSDKShared3cefeabeb1d55c64Variant2() => IsAutoSDKShared3cefeabeb1d55c64Variant2
            ? AutoSDKShared3cefeabeb1d55c64Variant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AutoSDKShared3cefeabeb1d55c64Variant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKShared3cefeabeb1d55c64(global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKShared3cefeabeb1d55c64Variant22> value) => new AutoSDKShared3cefeabeb1d55c64((global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKShared3cefeabeb1d55c64Variant22>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKShared3cefeabeb1d55c64Variant22>?(AutoSDKShared3cefeabeb1d55c64 @this) => @this.AutoSDKShared3cefeabeb1d55c64Variant2;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared3cefeabeb1d55c64(global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKShared3cefeabeb1d55c64Variant22>? value)
        {
            AutoSDKShared3cefeabeb1d55c64Variant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKShared3cefeabeb1d55c64 FromAutoSDKShared3cefeabeb1d55c64Variant2(global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKShared3cefeabeb1d55c64Variant22>? value) => new AutoSDKShared3cefeabeb1d55c64(value);

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared3cefeabeb1d55c64(
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared08bf5d361fc08707>? shared6a1866dc1efffce0,
            global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKShared3cefeabeb1d55c64Variant22>? autoSDKShared3cefeabeb1d55c64Variant2
            )
        {
            Shared6a1866dc1efffce0 = shared6a1866dc1efffce0;
            AutoSDKShared3cefeabeb1d55c64Variant2 = autoSDKShared3cefeabeb1d55c64Variant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AutoSDKShared3cefeabeb1d55c64Variant2 as object ??
            Shared6a1866dc1efffce0 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Shared6a1866dc1efffce0?.ToString() ??
            AutoSDKShared3cefeabeb1d55c64Variant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsShared6a1866dc1efffce0 && !IsAutoSDKShared3cefeabeb1d55c64Variant2 || !IsShared6a1866dc1efffce0 && IsAutoSDKShared3cefeabeb1d55c64Variant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared08bf5d361fc08707>, TResult>? shared6a1866dc1efffce0 = null,
            global::System.Func<global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKShared3cefeabeb1d55c64Variant22>, TResult>? autoSDKShared3cefeabeb1d55c64Variant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsShared6a1866dc1efffce0 && shared6a1866dc1efffce0 != null)
            {
                return shared6a1866dc1efffce0(Shared6a1866dc1efffce0!);
            }
            else if (IsAutoSDKShared3cefeabeb1d55c64Variant2 && autoSDKShared3cefeabeb1d55c64Variant2 != null)
            {
                return autoSDKShared3cefeabeb1d55c64Variant2(AutoSDKShared3cefeabeb1d55c64Variant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared08bf5d361fc08707>>? shared6a1866dc1efffce0 = null,

            global::System.Action<global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKShared3cefeabeb1d55c64Variant22>>? autoSDKShared3cefeabeb1d55c64Variant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsShared6a1866dc1efffce0)
            {
                shared6a1866dc1efffce0?.Invoke(Shared6a1866dc1efffce0!);
            }
            else if (IsAutoSDKShared3cefeabeb1d55c64Variant2)
            {
                autoSDKShared3cefeabeb1d55c64Variant2?.Invoke(AutoSDKShared3cefeabeb1d55c64Variant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared08bf5d361fc08707>>? shared6a1866dc1efffce0 = null,
            global::System.Action<global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKShared3cefeabeb1d55c64Variant22>>? autoSDKShared3cefeabeb1d55c64Variant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsShared6a1866dc1efffce0)
            {
                shared6a1866dc1efffce0?.Invoke(Shared6a1866dc1efffce0!);
            }
            else if (IsAutoSDKShared3cefeabeb1d55c64Variant2)
            {
                autoSDKShared3cefeabeb1d55c64Variant2?.Invoke(AutoSDKShared3cefeabeb1d55c64Variant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Shared6a1866dc1efffce0,
                typeof(global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared08bf5d361fc08707>),
                AutoSDKShared3cefeabeb1d55c64Variant2,
                typeof(global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKShared3cefeabeb1d55c64Variant22>),
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
        public bool Equals(AutoSDKShared3cefeabeb1d55c64 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared08bf5d361fc08707>?>.Default.Equals(Shared6a1866dc1efffce0, other.Shared6a1866dc1efffce0) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKShared3cefeabeb1d55c64Variant22>?>.Default.Equals(AutoSDKShared3cefeabeb1d55c64Variant2, other.AutoSDKShared3cefeabeb1d55c64Variant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AutoSDKShared3cefeabeb1d55c64 obj1, AutoSDKShared3cefeabeb1d55c64 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AutoSDKShared3cefeabeb1d55c64>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AutoSDKShared3cefeabeb1d55c64 obj1, AutoSDKShared3cefeabeb1d55c64 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutoSDKShared3cefeabeb1d55c64 o && Equals(o);
        }
    }
}
