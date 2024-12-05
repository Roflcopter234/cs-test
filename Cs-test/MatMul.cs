using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MatMul
{
    public List<List<double>> matMul(List<List<double>> l1, List<List<double>> l2)
    {
        if (l1[0].Count != l2.Count)
        {
            throw new Exception("MatMul: l1 and l2 dims do not match");
        }

        List<List<double>> result = new List<List<double>>();
        for (int i = 0; i < l1.Count; i++)
        {
            result.Add(new List<double>(new double[l2[0].Count]));
        }

        for (int i = 0; i < l1.Count; i++)
        {
            for (int j = 0; j < l2[0].Count; j++)
            {
                for (int k = 0; k < l2.Count; k++)
                {
                    result[i][j] += l1[i][k] * l2[k][j];
                }
            }
        }
        return result;
    }
}
