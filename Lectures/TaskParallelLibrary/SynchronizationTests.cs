using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace TaskParallelLibrary;

[TestClass]
public class SynchronizationTests 
{
    private const int Max = int.MaxValue;
    private Object Locker { get; } = new();
    private int _Count { get; set; }

    [TestMethod]
    public void IncrementCount() {
        for (int i = 0; i < Max; i++)
        {
            lock(Locker) 
            {
                _Count++;
            }
        }
        
    }

    public void DecrementCount() {
        for (int i = 0; i < Max; i++) 
        {
            lock (Locker) 
            {
                _Count--;
            }
        }
    }

    [TestMethod]
    public void Count_Property_Synchronized() {

        Task incrementTask = Task.Run(IncrementCount);
        Task decrementTask = Task.Run(DecrementCount);
        Task.WaitAll(decrementTask, incrementTask);
        Assert.AreNotEqual<int>(0, _Count);
    }


    
    [TestMethod]
    public void Count_LocalVariable_Synchronized() {
        Object locker = new(); 
        int count = 0;
        void decrementCount() {
            for (int i = 0; i < Max; i++) 
            {
                lock (locker) 
                {
                    count--;
                }
            }
        }
        void incrementCount() {
            for (int i = 0; i < Max; i++) {
                lock (locker) 
                { 
                count++;
                }
            }
        }
        
        Task incrementTask = Task.Run(incrementCount);
        Task decrementTask = Task.Run(decrementCount);
        Task.WaitAll(decrementTask, incrementTask);       
        Assert.AreNotEqual<int>(0, count); 
    }


    [TestMethod]
    public void Count_IncrementDecrement_Synchronized() {
        int count = 0;
        void decrementCount() {
            for (int i = 0; i < Max; i++) {
                Interlocked.Decrement(ref count);
            }
        }
        void incrementCount() {
            for (int i = 0; i < Max; i++) 
            {
                Interlocked.Increment(ref count);
            }
        }

        Task incrementTask = Task.Run(incrementCount);
        Task decrementTask = Task.Run(decrementCount);
        Task.WaitAll(decrementTask, incrementTask);
        Assert.AreNotEqual<int>(0, count);
    }
}
