using System.Collections.Generic;

namespace Properties
{
    using System;

    /// <summary>
    /// The class models a card.
    /// </summary>
    public class Card
    {
        private readonly string seed;
        private readonly string name;
        private readonly int ordinal;

        /// <summary>
        /// Initializes a new instance of the <see cref="Card"/> class.
        /// </summary>
        /// <param name="name">the name of the card.</param>
        /// <param name="seed">the seed of the card.</param>
        /// <param name="ordinal">the ordinal number of the card.</param>
        public Card(string name, string seed, int ordinal)
        {
            this.name = name;
            this.ordinal = ordinal;
            this.seed = seed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Card"/> class.
        /// </summary>
        /// <param name="tuple">the informations about the card as a tuple.</param>
        internal Card(Tuple<string, string, int> tuple) : this(tuple.Item1, tuple.Item2, tuple.Item3)
        {
        }

        // TODO improve
        public string GetSeed() => this.seed;

        // TODO improve
        public string GetName() => this.name;

        // TODO improve
        public int GetOrdinal() => this.ordinal;

        /// <inheritdoc cref="object.ToString"/>
        public override string ToString()
        {
            // TODO understand string interpolation
            return $"{this.GetType().Name}(Name={this.GetName()}, Seed={this.GetSeed()}, Ordinal={this.GetOrdinal()})";
        }

        // TODO generate Equals(object obj)
        private sealed class SeedNameOrdinalEqualityComparer : IEqualityComparer<Card>
        {
            public bool Equals(Card x, Card y)
            {
                if (ReferenceEquals(x, y)) return true;
                if (ReferenceEquals(x, null)) return false;
                if (ReferenceEquals(y, null)) return false;
                if (x.GetType() != y.GetType()) return false;
                return x.seed == y.seed && x.name == y.name && x.ordinal == y.ordinal;
            }

            public int GetHashCode(Card obj)
            {
                return HashCode.Combine(obj.seed, obj.name, obj.ordinal);
            }
        }

        // TODO generate GetHashCode()
    }
}
