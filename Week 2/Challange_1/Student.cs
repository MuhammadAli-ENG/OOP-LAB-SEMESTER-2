using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange_1
{
    public class Student
    {
        float t_aggregate;
        public const int data_count = 1000;
        public int arr_count = 0;
        public string[] Name = new string[data_count];
        public float[]  matric = new float[data_count];
        public float[] inter = new float[data_count];
        public float[] ecat = new float[data_count];

        public float[] all_aggr = new float[data_count];

        public Student()
        {
            t_aggregate = 0F;
            for (int i = 0; i < data_count; i++)
            { 
                all_aggr[i] = 0;
            }
        }

        public void AddStudent(string name, float m_mark, float i_mark, float e_mark)
        {
            Name[arr_count] = name;
            matric[arr_count] = m_mark;
            inter[arr_count] = i_mark;
            ecat[arr_count] = e_mark;
            arr_count++;
        }

        public void ShowStudents()
        {
            Console.WriteLine("Following are the data of students.....");
            for(int idx = 0; idx < arr_count; idx++)
            {
                Console.WriteLine("RegNo: {0} || Name: {1} || Matic Marks: {2} || Inter Marks: {3} || Ecat Marks: {4} || Aggregate: {5} \n", idx, Name[idx], matric[idx], inter[idx], ecat[idx], all_aggr[idx]);
            }
        }
        
        public float CalculateAllAgg(int idx)
        {
            float agg = 0.0F;
            agg = (((matric[idx] / 1100) * 100) * 0.3F) + (((inter[idx] / 1200) * 100) * 0.4F) + (((ecat[idx] / 400) * 100) * 0.3F);
            all_aggr[idx] = agg;
            return agg;
        }

        public float ShowTotalAgg()
        {
            float t_agg = 0F;
            for(int idx = 0; idx < arr_count; idx++)
            {
                t_agg = t_agg + all_aggr[idx];
            }

            t_agg = t_agg / (float)arr_count;
            t_aggregate = t_agg;
            return t_agg;
        }

        public void SeeTopStudents()
        {
            int first_max_idx = 0;
            int second_max_idx = 0;
            int third_max_idx = 0;

            for (int idx = 0; idx < arr_count; idx++)
            {
                if (all_aggr[idx] > all_aggr[first_max_idx])
                {
                    first_max_idx = idx;
                }
            }
            for (int idx = 0; idx < arr_count; idx++)
            {
                if (all_aggr[idx] > all_aggr[first_max_idx] && all_aggr[idx] != first_max_idx)
                {
                    second_max_idx = idx;
                }
            }
            for (int idx = 0; idx < arr_count; idx++)
            {
                if (all_aggr[idx] > all_aggr[first_max_idx] && all_aggr[idx] != first_max_idx && all_aggr[idx] != second_max_idx)
                {
                    third_max_idx = idx;
                }
            }

            Console.WriteLine("First Student is \"{0}\" with aggregate: \'{1}\' ", Name[first_max_idx], all_aggr[first_max_idx]);
            Console.WriteLine("Second Student is \"{0}\" with aggregate: \'{1}\' ", Name[second_max_idx], all_aggr[second_max_idx]);
            Console.WriteLine("Third Student is \"{0}\" with aggregate: \'{1}\' ", Name[third_max_idx], all_aggr[third_max_idx]);
        }
    }
}
