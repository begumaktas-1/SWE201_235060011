using System;

namespace SWE201_235060011
{
    public class Student
    {
        // Member variables (alanlar)
        private string _studentNumber;
        private string _fullName;
        private double _midterm;
        private double _final;

        // Properties (özellikler)
        public string StudentNumber
        {
            get { return _studentNumber; }
            set { _studentNumber = value; }
        }

        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
        }

        public double Midterm
        {
            get { return _midterm; }
            set { _midterm = value; }
        }

        public double Final
        {
            get { return _final; }
            set { _final = value; }
        }

        // Empty constructor (parametresiz kurucu)
        public Student()
        {
            _studentNumber = "";
            _fullName = "";
            _midterm = 0;
            _final = 0;
        }

        // Constructor with parameters (parametreli kurucu)
        public Student(string studentNumber, string fullName, double midterm, double final)
        {
            _studentNumber = studentNumber;
            _fullName = fullName;
            _midterm = midterm;
            _final = final;
        }

        // Ortalama hesaplayan fonksiyon
        public double CalculateAverage()
        {
            double average = (_midterm * 0.4) + (_final * 0.6);
            return average;
        }

        // Geçti mi kaldı mı söyleyen fonksiyon
        public string GetStatus()
        {
            double avg = CalculateAverage();

            if (avg >= 60)
                return "Geçti";
            else
                return "Kaldı";
        }

        // ToString override → ekrana düzgün yazdırmak için
        public override string ToString()
        {
            double avg = CalculateAverage();
            string status = GetStatus();

            return $"Öğrenci No: {StudentNumber}, İsim: {FullName}, Vize: {Midterm}, Final: {Final}, Ortalama: {avg}, Durum: {status}";
        }
    }
}
