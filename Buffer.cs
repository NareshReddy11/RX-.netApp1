using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace RXNEtExamples1
{
    class Buffer
    {
        static void Main(string[] args)
        {
            var subject = new Subject<int>();
            var distinct = subject.DistinctUntilChanged();
            distinct.Subscribe(i => Console.WriteLine("distinct.OnNext({0})", i),
            () => Console.WriteLine("distinct.OnCompleted()"));
            subject.OnNext(1);
            subject.OnNext(2);
            subject.OnNext(2);
            subject.OnNext(3);
            subject.OnNext(1);
            subject.OnNext(1);
            subject.OnNext(4);
            subject.OnNext(2);
            subject.OnNext(4);
            subject.OnCompleted();
        }
    }
}
/*
 * distinct.OnNext(1)
distinct.OnNext(2)
distinct.OnNext(3)
distinct.OnNext(1)
distinct.OnNext(4)
distinct.OnNext(2)
distinct.OnNext(4)
distinct.OnCompleted()
Press any key to continue . . .
*/