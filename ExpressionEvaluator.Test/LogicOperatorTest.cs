﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Feel.Test
{
    [TestClass]
    public class LogicOperatorTest
    {
        [TestMethod]
        public void NotEqualTest()
        {
            var expr = new ExpressionEvaluator("1 + x != y + 2");

            expr.SetVariableValue("x", 2);
            expr.SetVariableValue("y", 1);

            Assert.AreEqual(0, expr.Execute());

            expr.SetVariableValue("x", 25);
            expr.SetVariableValue("y", 25);

            Assert.AreEqual(1, expr.Execute());
        }

        [TestMethod]
        public void LessOrEqualTest()
        {
            var expr = new ExpressionEvaluator("1 + x <= y + 2");

            expr.SetVariableValue("x", 2);
            expr.SetVariableValue("y", 1);

            Assert.AreEqual(1, expr.Execute());

            expr.SetVariableValue("x", 25);
            expr.SetVariableValue("y", 25);

            Assert.AreEqual(1, expr.Execute());

            expr.SetVariableValue("x", 200);
            expr.SetVariableValue("y", 20);

            Assert.AreEqual(0, expr.Execute());
        }

        [TestMethod]
        public void LessTest()
        {
            var expr = new ExpressionEvaluator("x + 1 < 2 + y");

            expr.SetVariableValue("x", 2);
            expr.SetVariableValue("y", 1);

            Assert.AreEqual(0, expr.Execute());

            expr.SetVariableValue("x", 25);
            expr.SetVariableValue("y", 25);

            Assert.AreEqual(1, expr.Execute());

            expr.SetVariableValue("x", -21);
            expr.SetVariableValue("y", -23);

            Assert.AreEqual(0, expr.Execute());
        }

        [TestMethod]
        public void GreatherTest()
        {
            var expr = new ExpressionEvaluator("2 + x^2 > sqrt(y) + 2");

            expr.SetVariableValue("x", 2);
            expr.SetVariableValue("y", 16);

            Assert.AreEqual(0, expr.Execute());

            expr.SetVariableValue("x", 25);
            expr.SetVariableValue("y", 81);

            Assert.AreEqual(1, expr.Execute());

            expr.SetVariableValue("x", 2);
            expr.SetVariableValue("y", 25);

            Assert.AreEqual(0, expr.Execute());
        }

        [TestMethod]
        public void GreaterOrEqualTest()
        {
            var expr = new ExpressionEvaluator("1 + x * 2 >= 2 * y + 1");

            expr.SetVariableValue("x", 4);
            expr.SetVariableValue("y", 2);

            Assert.AreEqual(1, expr.Execute());

            expr.SetVariableValue("x", 24);
            expr.SetVariableValue("y", 75);

            Assert.AreEqual(0, expr.Execute());

            expr.SetVariableValue("x", 0);
            expr.SetVariableValue("y", 0);

            Assert.AreEqual(1, expr.Execute());
        }

        [TestMethod]
        public void AndTest()
        {
            var expr = new ExpressionEvaluator("x + 1 > 0 && y + 2 < 0");

            expr.SetVariableValue("x", 0);
            expr.SetVariableValue("y", -5);

            Assert.AreEqual(1, expr.Execute());


            expr.SetVariableValue("x", -10);
            expr.SetVariableValue("y", 10);

            Assert.AreEqual(0, expr.Execute());


            expr.SetVariableValue("x", 25);
            expr.SetVariableValue("y", 0);

            Assert.AreEqual(0, expr.Execute());


            expr.SetVariableValue("x", -25);
            expr.SetVariableValue("y", -10);

            Assert.AreEqual(0, expr.Execute());
        }

        [TestMethod]
        public void OrTest()
        {
            var expr = new ExpressionEvaluator("x + 1 > 0 || y + 2 < 0");

            expr.SetVariableValue("x", -10);
            expr.SetVariableValue("y", 10);

            Assert.AreEqual(0, expr.Execute());

            expr.SetVariableValue("x", 0);
            expr.SetVariableValue("y", -5);

            Assert.AreEqual(1, expr.Execute());


            expr.SetVariableValue("x", 25);
            expr.SetVariableValue("y", 0);

            Assert.AreEqual(1, expr.Execute());


            expr.SetVariableValue("x", -25);
            expr.SetVariableValue("y", -10);

            Assert.AreEqual(1, expr.Execute());
        }
    }
}
