using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace RXNEtExamples1
{
    class Fempty
    {
        static void Main(string[] args)
        {
            var empty = Observable.Empty<string>();
            var subject = new ReplaySubject<string>();
            subject.OnNext("hello");
            subject.OnCompleted();
            empty.Subscribe(a =>
            {
                Console.WriteLine(a);
            });
        }
    }
}
