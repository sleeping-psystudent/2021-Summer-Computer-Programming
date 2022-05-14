using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class12_Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] IDs_enrollment = { "A*102", "G*406", "B*503", "F*205", "D*811", "C*709" };
            int[] labels_enrollment = new int [6];
            string[] grouptypes_enrollment = new string[6];
            Random label = new Random(Guid.NewGuid().GetHashCode());
            int i;
            for (i= 0;i<6;i++)
            {
                labels_enrollment[i] = label.Next();
                int n = label.Next();
                if(n%2==1)
                {
                    grouptypes_enrollment[i] = "Controll";
                }
                else
                {
                    grouptypes_enrollment[i] = "Treatment";
                }
            }

            int[] labels_trial = new int[6];
            ShuffleLabels(labels_enrollment, labels_trial);

            double[] data_trial = new double[6];
            ConductExperiment(label, labels_trial, data_trial);

            double[] real_data_trial = new double[6];
            ShuffleLabels2(real_data_trial, data_trial);

            string[] ID_treatment = new string[6];
            string[] ID_control = new string[6];
            double[] data_treatment = new double[6];
            double[] data_control = new double[6];

            int i_treatment = 0;
            int i_control = 0;
            for(i=0;i<6;i++)
            {
                if (grouptypes_enrollment[i] == "Treatment")
                {
                    ID_treatment[i_treatment] = IDs_enrollment[i];
                    data_treatment[i_treatment] = real_data_trial[i];
                    i_treatment++;
                }
                else
                {
                    ID_control[i_control] = IDs_enrollment[i];
                    data_control[i_control] = real_data_trial[i];
                    i_control++;
                }
            }
            Console.WriteLine(i_control);
            Console.WriteLine(i_treatment);

            Console.WriteLine("Treatment Group");
            for (i = 0; i < i_treatment; i++) 
            {
                Console.WriteLine("ID: "+ID_treatment[i]+", data: "+data_treatment[i]);
            }

            Console.WriteLine("Control Group");
            for (i = 0; i < i_control; i++) 
            {
                Console.WriteLine("ID: " + ID_control[i] + ", data: " + data_control[i]);
            }
            Console.ReadKey();
        }

        static void ShuffleLabels(int[] labels_enrollment, int[] labels_trial)
        {
            labels_trial[0] = labels_enrollment[4];
            labels_trial[1] = labels_enrollment[2];
            labels_trial[2] = labels_enrollment[0];
            labels_trial[3] = labels_enrollment[3];
            labels_trial[4] = labels_enrollment[5];
            labels_trial[5] = labels_enrollment[1];
        }

        static void ShuffleLabels2(double[] real_data_trial, double[] data_trial)
        {
            real_data_trial[4] = data_trial[0];
            real_data_trial[2] = data_trial[1];
            real_data_trial[0] = data_trial[2];
            real_data_trial[3] = data_trial[3];
            real_data_trial[5] = data_trial[4];
            real_data_trial[1] = data_trial[5];
        }

        static void ConductExperiment(Random rand,int[] labels_trial, double[] data_trial)
        {
            int n = labels_trial.Length;
            for (int i = 0; i < n; ++i) // in experiment order 
            {
                data_trial[i] = rand.NextDouble();
            }
        }
    }
}
