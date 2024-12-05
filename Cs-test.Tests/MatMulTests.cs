using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class MatMulTests
{
    [TestMethod]
    public void matmul_test_simple()
    {
        MatMul matMul = new MatMul();

        List<List<double>> l1 = new List<List<double>>();
        l1.Add(new List<double>() { 1.0, 2.0});
        l1.Add(new List<double>() { 3.0, 4.0 });

        List<List<double>> l2 = new List<List<double>>();
        l2.Add(new List<double>() { 5.0, 6.0 });
        l2.Add(new List<double>() { 7.0, 8.0 });

        List<List<double>> expected = new List<List<double>>();
        expected.Add(new List<double>() { 19.0, 22.0 });
        expected.Add(new List<double>() { 43.0, 50.0 });

        List<List<double>> result = matMul.matMul(l1, l2);
        for (int i = 0; i < expected.Count; i++)
        {
            CollectionAssert.AreEqual(expected[i], result[i]);
        }
    }

    [TestMethod]
    public void matmul_test_simple2()
    {
        MatMul matMul = new MatMul();

        List<List<double>> l1 = new List<List<double>>();
        l1.Add(new List<double>() { 1.0, 2.0 });
        l1.Add(new List<double>() { 3.0, 4.0 });
        l1.Add(new List<double>() { 5.0, 6.0 });

        List<List<double>> l2 = new List<List<double>>();
        l2.Add(new List<double>() { 1.0, 3.0, 5.0, 7.0 });
        l2.Add(new List<double>() { 2.0, 4.0, 6.0, 8.0 });

        List<List<double>> expected = new List<List<double>>();
        expected.Add(new List<double>() { 5.0, 11.0, 17.0, 23.0 });
        expected.Add(new List<double>() { 11.0, 25.0, 39.0, 53.0 });
        expected.Add(new List<double>() { 17.0, 39.0, 61.0, 83.0 });

        List<List<double>> result = matMul.matMul(l1, l2);
        for (int i = 0; i < expected.Count; i++)
        {
            CollectionAssert.AreEqual(expected[i], result[i]);
        }
    }

    [TestMethod]
    public void matmul_test_incompatible_size()
    {
        MatMul matMul = new MatMul();

        List<List<double>> l1 = new List<List<double>>();
        l1.Add(new List<double>() { 1.0 });
        l1.Add(new List<double>() { 3.0 });

        List<List<double>> l2 = new List<List<double>>();
        l2.Add(new List<double>() { 5.0, 11.0, 17.0, 23.0 });
        l2.Add(new List<double>() { 11.0, 25.0, 39.0, 53.0 });
        l2.Add(new List<double>() { 17.0, 39.0, 61.0, 83.0 });

        Assert.ThrowsException<Exception>(() => matMul.matMul(l1, l2));
    }
}
