using System;

namespace FirstProgram
{
    class Car
    {
        public string model;
        public int year;
        public string type;

        public Car(string model)
        {
            this.model = model;
        }

        public Car(int year, string model, string type) : this(model)
        {
            this.year = year;
            this.type = type;
        }
        public string CarMethod()
        {
            return ($"The car {model} was built in year {year} is of type {type}");
        }
    }
}