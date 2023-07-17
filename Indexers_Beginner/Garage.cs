namespace Indexers
{
    public class Garage
    {
        //define array
        private Car[] availableCars;

        public Garage(params Car[] cars)
        {
            availableCars = cars;
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