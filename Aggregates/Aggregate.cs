using System;
using System.Collections.Generic;
using System.Text;

namespace Aggregates
{
    /// <summary>
    /// Aggregate base class
    /// </summary>
    public class Aggregate
    {
        /// <summary>
        /// The unique ID of the aggregate.
        /// </summary>
        public Guid Id { get; internal set; }
    }
}
