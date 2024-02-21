using Movie_Database_Lab;


List<Movie> movies = new List<Movie>();
movies.Add(new Movie("Anchorman", "comedy"));
movies.Add(new Movie("Happy Gilmore", "comedy"));
movies.Add(new Movie("Star Wars: Episode III", "scifi"));
movies.Add(new Movie("The Matrix", "scifi"));
movies.Add(new Movie("The Conjuring", "horror"));
movies.Add(new Movie("It", "horror"));
movies.Add(new Movie("Gone Girl", "drama"));
movies.Add(new Movie("Unbreakable", "drama"));
movies.Add(new Movie("The Lion King", "animated"));
movies.Add(new Movie("Toy Story", "animated"));

Console.WriteLine("Welcome to the Movie List Application!");
Console.WriteLine("There are 10 movies in this list.");
string userInput = "";
while (true)
{
    while (true)
    {
        Console.WriteLine("What category are you interested in? There are 5 options: Comedy, Drama, Horror, Animated, and Scifi");
        userInput = Console.ReadLine().ToLower().Trim();
        if (userInput == "comedy")
        {
            break;
        }
        else if (userInput == "drama")
        {
            break;
        }
        else if (userInput == "horror")
        {
            break;
        }
        else if (userInput == "animated")
        {
            break;
        }
        else if (userInput == "scifi")
        {
            break;
        }
        else
        {
            Console.WriteLine("That is not a valid option. Please try again");
        }
    }


    List<Movie> userSelection = movies.Where(x => x.Category.ToLower().Trim() == userInput).ToList();

    foreach (Movie movie in userSelection)
    {
        Console.WriteLine(movie.Title);
    }

    Console.WriteLine("Would you like to see another category? (y/n) ");
    string goAgain = Console.ReadLine().ToLower().Trim();
    if (goAgain != "y")
    {
        break;
    }
    
}

Console.WriteLine("Thank you!");

