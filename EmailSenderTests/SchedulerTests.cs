using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmailSender;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace EmailSender.Tests
{
    [TestClass()]
    public class SchedulerTests
    {
        Scheduler scheduler;
        TimeSpan timeSpan;

        [TestInitialize]
        public void TestInitialize()
        {
            scheduler = new Scheduler();
            timeSpan = new TimeSpan();
            Debug.WriteLine("Test Initialize");
            scheduler.DatesEmailTests = new Dictionary<DateTime, string>()
            {
                {new DateTime(2016, 12, 24, 00, 0, 0), "text1" },
                {new DateTime(2016, 12, 24, 00, 30, 0), "text2" },
                {new DateTime(2016, 12, 24, 01, 0, 0), "text3" }
            };
        }
        [TestMethod]
        public void TimeTick_Dictionare_correct()
        {
            DateTime dt1 = new DateTime(2016, 12, 24, 00, 0, 0);
            DateTime dt2 = new DateTime(2016, 12, 24, 00, 30, 0);
            DateTime dt3 = new DateTime(2016, 12, 24, 01, 0, 0);

            if (scheduler.DatesEmailTests.Keys.First<DateTime>().ToShortTimeString() == dt1.ToShortTimeString())
            {
                Debug.WriteLine("Body " + scheduler.DatesEmailTests[scheduler.DatesEmailTests.Keys.First<DateTime>()]);
                Debug.WriteLine("Subject " + $"Distro from {scheduler.DatesEmailTests.Keys.First<DateTime>().ToShortDateString()} {scheduler.DatesEmailTests.Keys.First<DateTime>().ToShortTimeString()}");
                scheduler.DatesEmailTests.Remove(scheduler.DatesEmailTests.Keys.First<DateTime>());
            }
            if(scheduler.DatesEmailTests.Keys.First<DateTime>().ToShortTimeString() == dt2.ToShortTimeString())
            {
                Debug.WriteLine("Body " + scheduler.DatesEmailTests[scheduler.DatesEmailTests.Keys.First<DateTime>()]);
                Debug.WriteLine("Subject " + $"Distro from {scheduler.DatesEmailTests.Keys.First<DateTime>().ToShortDateString()} {scheduler.DatesEmailTests.Keys.First<DateTime>().ToShortTimeString()}");
                scheduler.DatesEmailTests.Remove(scheduler.DatesEmailTests.Keys.First<DateTime>());
            }
            if (scheduler.DatesEmailTests.Keys.First<DateTime>().ToShortTimeString() == dt3.ToShortTimeString())
            {
                Debug.WriteLine("Body " + scheduler.DatesEmailTests[scheduler.DatesEmailTests.Keys.First<DateTime>()]);
                Debug.WriteLine("Subject " + $"Distro from {scheduler.DatesEmailTests.Keys.First<DateTime>().ToShortDateString()} {scheduler.DatesEmailTests.Keys.First<DateTime>().ToShortTimeString()}");
                scheduler.DatesEmailTests.Remove(scheduler.DatesEmailTests.Keys.First<DateTime>());
            }
            Assert.AreEqual(0, scheduler.DatesEmailTests.Count);
        }

        [TestMethod()]
        public void GetSendTimeTest_empty_timeSpan()
        {
            string strTimeTest = string.Empty;
            TimeSpan tSpan = scheduler.GetSendTime(strTimeTest);
            Assert.AreEqual(timeSpan, tSpan);
        }

        [TestMethod]
        public void GetSendTime_sdf_timeSpan()
        {
            string strTimeTest = "sdf";
            TimeSpan tSpan = scheduler.GetSendTime(strTimeTest);
            Assert.AreEqual(timeSpan, tSpan);
        }
        [TestMethod]
        public void GetSendTime_correctTime_Equal ()
        {
            string strTimeTest = "12:12";
            TimeSpan tsCorrect = new TimeSpan(12, 12, 0);
            TimeSpan tSpan = scheduler.GetSendTime(strTimeTest);
            Assert.AreEqual(tsCorrect, tSpan);
        }
        [TestMethod]
        public void GetSendTime_IncorrectTime_timeSpan()
        {
            string strTimeTest = "25:12";
            TimeSpan tSpan = scheduler.GetSendTime(strTimeTest);
            Assert.AreEqual(timeSpan, tSpan);
        }
        [TestMethod]
        public void GetSendTime_IncorrectMin_timeSpan()
        {
            string strTimeTest = "12:65";
            TimeSpan tSpan = scheduler.GetSendTime(strTimeTest);
            Assert.AreEqual(timeSpan, tSpan);
        }
    }
}