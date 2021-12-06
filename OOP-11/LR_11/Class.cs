using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_11
{
    public class BelStudent //класс книги
    {
        public string BelAuthor { get; set; }
        public string Belname { get; set; }
        public BelStudent(string belAuthor, string belname)
        {
            BelAuthor = belAuthor;
            Belname = belname;
        }
    }
    class Player //класс игрок
    {
        public string Name { get; set; }
        public string Team { get; set; }
    }
    class Team //класс команда 
    {
        public string Name { get; set; }
        public string Country { get; set; }
    }
    public class Student //класс книга 
    {
        public string name; 
        public ushort year;
        private uint math;
        private uint phith;
        public uint rus;
        public uint ball;
        public Student(string name,  ushort year, uint math, uint phith, uint rus, uint ball)
        {
            this.name = name; //задание значений свойствам 
           
            this.year = year;
            this.math = math;
            this.phith = phith;
            this.rus = rus;
            this.ball = ball;
        }
        public string Name 
        {
            get { return name; }
            set { name = value; }
        }
      
        public ushort Year  
        {
            get { return year; }
            set
            {
                if (year <= 150)
                    year = value;
                else year = 0;
            }
        }
        public uint Math 
        {
            get { return math; }
            set { math = value; }
        }
        public uint Phith //цена
        {
            get { return phith; }
            set { phith = value; }
        }
        public uint Rus 
        {
            get { return rus; }
            set { rus = value; }
        }
        public uint Ball 
        {
            get { return ball; }
            set { ball = value; }
        }
    }
}


