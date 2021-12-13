using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Multithreading;



namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<EmployeDetails> EmpDetailList = new List<EmployeDetails>();
            EmpDetailList.Add(new EmployeDetails(1, "vishal", "pune", 41101));
            EmpDetailList.Add(new EmployeDetails(2, "raj", "pune", 41101));
            EmpDetailList.Add(new EmployeDetails(3, "vicky", "pune", 41101));
            EmpDetailList.Add(new EmployeDetails(4, "vishal", "pune", 41101));
            EmpDetailList.Add(new EmployeDetails(5, "vishal", "pune", 41101));
            EmpDetailList.Add(new EmployeDetails(6, "rajesh", "surat", 41101));
        }
    }
}
