namespace AnonymousDelegates
{
    public delegate void myPet(string name);

    public static class AnonymousMethod
    {
        public static void AnonymousMethodSample(myPet mypet, string colour)
        {
            colour = "Green" + colour;
            mypet(colour);
        }

    }
}