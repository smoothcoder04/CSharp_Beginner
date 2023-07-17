using System;

namespace Indexers
{
    class Garage
    {
        private Car[] availableCars;

        public Garage(params Car[] cars)
        {
            availableCars = cars;
        }

        //Overload the indexer to check if the specific model exists in the garage
        public bool this[string modelofCar]
        {
            //only the get block
            get
            {
                foreach (var car in availableCars)
                {
                    if (car.Model == modelofCar)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        public Car this[int index]
        {
            get
            {
                return availableCars[index];
            }

            set
            {
                availableCars[index] = value;
            }
        }

    }
}