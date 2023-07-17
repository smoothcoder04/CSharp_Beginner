namespace ReadOnlyFields
{
    internal class Person
    {
        //field
        public readonly DateTime Birthdate;
        public Person(DateTime birthdate)
        {
            this.Birthdate = birthdate;
        }
    }
}