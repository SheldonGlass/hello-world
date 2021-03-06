﻿using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace NUnit3Samples._6._Managing_Tests.A._ControllingOrder
{
    [TestFixture]
    public class OrderingTest
    {
        public static IEnumerable<TestCaseData> MainTests
        {
            get
            {
                yield return new TestCaseData(new Action(() =>
                {
                    System.Threading.Thread.Sleep(5000);
                    Console.WriteLine("this is output 1");
                }
                ));
                yield return new TestCaseData(new Action(() =>
                {
                    System.Threading.Thread.Sleep(5000);
                    Console.WriteLine("this is output 2");
                }
                ));
                yield return new TestCaseData(new Action(() =>
                {
                    System.Threading.Thread.Sleep(5000);
                    Console.WriteLine("this is output 3");
                }
                ));
            }
        }

        [Test]
        [TestCaseSource(nameof(MainTests))]
        public void TestRunner(Action func)
        {
            func();
        }
    }
}
