using System;

namespace EventSourced.Simple.Aggregate.Events
{
    public class CounterIntitialized
    {
        public CounterIntitialized(Guid counterId, int initialValue)
        {
            CounterId = counterId;
            InitialValue = initialValue;
        }

        public Guid CounterId { get; set; }
        public int InitialValue { get; set; }

    }
}
