using HomeWorkCalculate.ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkCalculate.ServiceLayer.Services
{
    internal class CalculateService : ICalculateService
    {
        public int Calculate(int[] arr)
        {
            {
                int result = 1;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] < 20 && arr[i] > 1)
                    {
                        result = arr[i] * result;

                    }
                }
                return result;

            }
        }

        public double GetCalculate(int[] arr)
        {
            {
                int sum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        sum += arr[i];
                    }
                }
                double result = Math.Pow(sum, 2);

                return result;

            }


        }

        
        
          
        
    }
}
    

