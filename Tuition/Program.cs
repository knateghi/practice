using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuition
{
    class Program
    {
        static void Main(string[] args)
        {
          PayingStudent poorStudent = new PayingStudent();
            FreeStudent luckyStudent = new FreeStudent();
             Console.WriteLine("{0,4} {1,21} {2,25}", "Name", "Tuition Fees","Credits");
            poorStudent.Name = "badbakht";

            poorStudent.Credits = 2;
            Console.WriteLine("{0,4} {1,14} {2,25}", poorStudent.Name, poorStudent.Tuition.ToString("C"),poorStudent.Credits);

            luckyStudent.Name = "emira";
            luckyStudent.Credits = 5;
            Console.WriteLine("{0,4} {1,14} {2,28} ",luckyStudent.Name,luckyStudent.Tuition.ToString("C"),luckyStudent.Credits);
            Console.ReadKey();

        }
    }
    class PayingStudent
    {
        protected int credits;
        protected double tuition;
        private string name;
        public const double RATE = 55.75;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
       
       public virtual int Credits
        {
            get
            {
               return this.credits;
            }
            set
            {
                this.credits = value;
                tuition = credits * RATE;
            }

        }
        public double Tuition
        {
            get
            {
                return this.tuition;
            }
        }

    }
    class FreeStudent:PayingStudent
    {
        public override int Credits 
        {
            get
            {
                return this.credits;

            }
            set
            {
                this.credits = value;
                tuition = 0;
            }

        }
    }
 }
    

