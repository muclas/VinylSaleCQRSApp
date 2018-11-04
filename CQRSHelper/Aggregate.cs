using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSHelper
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
