#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AutoSDKShared9296e9c5692fbba2 : global::System.IEquatable<AutoSDKShared9296e9c5692fbba2>
    {
        /// <summary>
        /// Network access policy for the sandbox.\n    Controls which external hosts the sandbox can communicate with.\n    Use \"allow-all\" mode to allow all traffic, \"deny-all\" to block all traffic or \"custom\" to provide specific rules.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKShared4f336dbaf7392e8f? Shared4f336dbaf7392e8f { get; init; }
#else
        public global::Vercel.AutoSDKShared4f336dbaf7392e8f? Shared4f336dbaf7392e8f { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shared4f336dbaf7392e8f))]
#endif
        public bool IsShared4f336dbaf7392e8f => Shared4f336dbaf7392e8f != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShared4f336dbaf7392e8f(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKShared4f336dbaf7392e8f? value)
        {
            value = Shared4f336dbaf7392e8f;
            return IsShared4f336dbaf7392e8f;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKShared4f336dbaf7392e8f PickShared4f336dbaf7392e8f() => IsShared4f336dbaf7392e8f
            ? Shared4f336dbaf7392e8f!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shared4f336dbaf7392e8f' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKShared650e942fd9ba5744? Shared650e942fd9ba5744 { get; init; }
#else
        public global::Vercel.AutoSDKShared650e942fd9ba5744? Shared650e942fd9ba5744 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shared650e942fd9ba5744))]
#endif
        public bool IsShared650e942fd9ba5744 => Shared650e942fd9ba5744 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShared650e942fd9ba5744(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKShared650e942fd9ba5744? value)
        {
            value = Shared650e942fd9ba5744;
            return IsShared650e942fd9ba5744;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKShared650e942fd9ba5744 PickShared650e942fd9ba5744() => IsShared650e942fd9ba5744
            ? Shared650e942fd9ba5744!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shared650e942fd9ba5744' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKShared9296e9c5692fbba2(global::Vercel.AutoSDKShared4f336dbaf7392e8f value) => new AutoSDKShared9296e9c5692fbba2((global::Vercel.AutoSDKShared4f336dbaf7392e8f?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKShared4f336dbaf7392e8f?(AutoSDKShared9296e9c5692fbba2 @this) => @this.Shared4f336dbaf7392e8f;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared9296e9c5692fbba2(global::Vercel.AutoSDKShared4f336dbaf7392e8f? value)
        {
            Shared4f336dbaf7392e8f = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKShared9296e9c5692fbba2 FromShared4f336dbaf7392e8f(global::Vercel.AutoSDKShared4f336dbaf7392e8f? value) => new AutoSDKShared9296e9c5692fbba2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKShared9296e9c5692fbba2(global::Vercel.AutoSDKShared650e942fd9ba5744 value) => new AutoSDKShared9296e9c5692fbba2((global::Vercel.AutoSDKShared650e942fd9ba5744?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKShared650e942fd9ba5744?(AutoSDKShared9296e9c5692fbba2 @this) => @this.Shared650e942fd9ba5744;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared9296e9c5692fbba2(global::Vercel.AutoSDKShared650e942fd9ba5744? value)
        {
            Shared650e942fd9ba5744 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKShared9296e9c5692fbba2 FromShared650e942fd9ba5744(global::Vercel.AutoSDKShared650e942fd9ba5744? value) => new AutoSDKShared9296e9c5692fbba2(value);

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared9296e9c5692fbba2(
            global::Vercel.AutoSDKShared4f336dbaf7392e8f? shared4f336dbaf7392e8f,
            global::Vercel.AutoSDKShared650e942fd9ba5744? shared650e942fd9ba5744
            )
        {
            Shared4f336dbaf7392e8f = shared4f336dbaf7392e8f;
            Shared650e942fd9ba5744 = shared650e942fd9ba5744;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Shared650e942fd9ba5744 as object ??
            Shared4f336dbaf7392e8f as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Shared4f336dbaf7392e8f?.ToString() ??
            Shared650e942fd9ba5744?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsShared4f336dbaf7392e8f && !IsShared650e942fd9ba5744 || !IsShared4f336dbaf7392e8f && IsShared650e942fd9ba5744;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vercel.AutoSDKShared4f336dbaf7392e8f, TResult>? shared4f336dbaf7392e8f = null,
            global::System.Func<global::Vercel.AutoSDKShared650e942fd9ba5744, TResult>? shared650e942fd9ba5744 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsShared4f336dbaf7392e8f && shared4f336dbaf7392e8f != null)
            {
                return shared4f336dbaf7392e8f(Shared4f336dbaf7392e8f!);
            }
            else if (IsShared650e942fd9ba5744 && shared650e942fd9ba5744 != null)
            {
                return shared650e942fd9ba5744(Shared650e942fd9ba5744!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vercel.AutoSDKShared4f336dbaf7392e8f>? shared4f336dbaf7392e8f = null,

            global::System.Action<global::Vercel.AutoSDKShared650e942fd9ba5744>? shared650e942fd9ba5744 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsShared4f336dbaf7392e8f)
            {
                shared4f336dbaf7392e8f?.Invoke(Shared4f336dbaf7392e8f!);
            }
            else if (IsShared650e942fd9ba5744)
            {
                shared650e942fd9ba5744?.Invoke(Shared650e942fd9ba5744!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vercel.AutoSDKShared4f336dbaf7392e8f>? shared4f336dbaf7392e8f = null,
            global::System.Action<global::Vercel.AutoSDKShared650e942fd9ba5744>? shared650e942fd9ba5744 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsShared4f336dbaf7392e8f)
            {
                shared4f336dbaf7392e8f?.Invoke(Shared4f336dbaf7392e8f!);
            }
            else if (IsShared650e942fd9ba5744)
            {
                shared650e942fd9ba5744?.Invoke(Shared650e942fd9ba5744!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Shared4f336dbaf7392e8f,
                typeof(global::Vercel.AutoSDKShared4f336dbaf7392e8f),
                Shared650e942fd9ba5744,
                typeof(global::Vercel.AutoSDKShared650e942fd9ba5744),
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
        public bool Equals(AutoSDKShared9296e9c5692fbba2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKShared4f336dbaf7392e8f?>.Default.Equals(Shared4f336dbaf7392e8f, other.Shared4f336dbaf7392e8f) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKShared650e942fd9ba5744?>.Default.Equals(Shared650e942fd9ba5744, other.Shared650e942fd9ba5744)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AutoSDKShared9296e9c5692fbba2 obj1, AutoSDKShared9296e9c5692fbba2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AutoSDKShared9296e9c5692fbba2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AutoSDKShared9296e9c5692fbba2 obj1, AutoSDKShared9296e9c5692fbba2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutoSDKShared9296e9c5692fbba2 o && Equals(o);
        }
    }
}
