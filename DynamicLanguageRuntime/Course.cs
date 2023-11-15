namespace DynamicLanguageRuntime
{
    public class Course
    {
        public string Title { get; set; }
        public dynamic Duration { get; set; }

        //Method with dynamic return type
        public dynamic GetCourseDuration(string format)
        {
            if (format == "string")
            {
                return $"{Duration} weekly";
            }
            else if (format == "int")
            {
                return Duration;
            }
            else
            {
                return "Invalid format provided.";
            }
        }
    }
}